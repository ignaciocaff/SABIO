using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using RestServiceSabio.DbManager;
using RestServiceSabio.Model;
using RestServiceSabio.Entities;
using System.Linq;

namespace RestServiceSabio.Managers
{
    public class SessionManager : DbConnection
    {
        SabioDbContext context = new SabioDbContext();
        private const String ANDROIDIN = "ANDROIDIN";
        private const String ANDROIDOUT = "ANDROIDOUT";

        public List<Usuario> obtenerListadoUsuarios()
        {
            // List<Usuario> listadoUsuarios = new List<Usuario>();
            List<Usuario> listadoUsuariosDto = new List<Usuario>();
            try
            {
                //Usuario user = new Usuario();
                List<Usuarios> listadoUsuarios = context.Usuarios.Where(x => x.Area == 8).ToList();
                foreach (Usuarios users in listadoUsuarios)
                {
                    Usuario user = new Usuario();
                    user.idUsuario = users.Numero;
                    user.loginUsuario = users.Login;
                    listadoUsuariosDto.Add(user);
                }


                /*open();
                String sqlQuery = "SELECT NUMERO,LOGIN FROM USUARIOS WHERE AREA=8";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                FbDataReader usuariosReader = sqlCommand.ExecuteReader();

                while (usuariosReader.Read())
                {
                    Usuario user = new Usuario();
                    user.idUsuario = usuariosReader.GetInt32(0);
                    user.loginUsuario = usuariosReader.GetString(1);
                    listadoUsuarios.Add(user);
                }
                usuariosReader.Close();
                close();*/
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }
            return listadoUsuariosDto;
        }


        public bool logIn(Usuario user, DatosLog datosLog)
        {
            List<Usuario> listadoUsuarios = obtenerListadoUsuarios();

            foreach (Usuario usuario in listadoUsuarios)
            {
                if (user.loginUsuario == usuario.loginUsuario)
                {
                    //Modificar el atributo HABILI a 1
                    modificarEstado(usuario, ANDROIDIN);
                    //Loguear en LOGS
                    auditoriaLog(usuario, ANDROIDIN, datosLog);
                    return true;
                }
            }
            return false;
        }

        public bool logOut(Usuario user, DatosLog datosLog)
        {
            List<Usuario> listadoUsuarios = obtenerListadoUsuarios();

            foreach (Usuario usuario in listadoUsuarios)
            {
                if (user.loginUsuario == usuario.loginUsuario)
                {
                    //Modificar el atributo HABILI a 0
                    modificarEstado(usuario, ANDROIDOUT);
                    //Loguear en LOGS
                    auditoriaLog(usuario, ANDROIDOUT, datosLog);
                    return true;
                }
            }
            return false;
        }

        public void auditoriaLog(Usuario user, String operacion, DatosLog datosLog)
        {
            try
            {
                int id = 0;
                String observaciones = "Marca: " + datosLog.marca_dispositivo + " Modelo: " + datosLog.modelo_dispositivo + " Bateria: " + datosLog.porcentaje_bateria + "%" + " Ubicacion: " + datosLog.ubicacion;
                open();
                String sqlQuery = "select next value for GEN_LOG from RDB$DATABASE";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                FbDataReader idReader = sqlCommand.ExecuteReader();

                while (idReader.Read())
                {
                    id = idReader.GetInt32(0);
                }
                idReader.Close();

                FbTransaction insertTransaction = connection.BeginTransaction();
                FbCommand insertCommand = new FbCommand();
                insertCommand.CommandText = "insert into LOGS (NUMERO,CASOUS,FECHA,USUARI,OBSERV,WINUSE,WINNET) values" +
                    " (" + id + ",'" + operacion + "'," + "CURRENT_TIMESTAMP" + "," + user.idUsuario + ",'" + observaciones + "'," + "'USUARIO'" + "," + "'APPMOVIL'" + ")";
                insertCommand.Connection = connection;
                insertCommand.Transaction = insertTransaction;

                //updateCommand.Parameters.Add("@USER_FIELD", userField);
                insertCommand.ExecuteNonQuery();
                insertTransaction.Commit();
                insertCommand.Dispose();
                close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public void modificarEstado(Usuario user, String operacion)
        {
            try
            {
                switch (operacion)
                {
                    case ANDROIDIN:
                        context.Usuarios.Where(x => x.Login == user.loginUsuario).ToList().ForEach(y => y.Habili = 1);
                        context.SaveChanges();
                        break;
                    case ANDROIDOUT:
                        context.Usuarios.Where(x => x.Login == user.loginUsuario).ToList().ForEach(y => y.Habili = 0);
                        context.SaveChanges();
                        break;
                }
                /*open();
                FbTransaction updateTransaction = connection.BeginTransaction();
                FbCommand updateCommand = new FbCommand();

                updateCommand.CommandText = "UPDATE USUARIOS SET HABILI = @OP_ID WHERE LOGIN = @USER_FIELD";
                updateCommand.Connection = connection;
                updateCommand.Transaction = updateTransaction;

                switch (operacion)
                {
                    case ANDROIDIN:
                        updateCommand.Parameters.Add("@OP_ID", true);
                        break;
                    case ANDROIDOUT:
                        updateCommand.Parameters.Add("@OP_ID", false);
                        break;
                }

                updateCommand.Parameters.Add("@USER_FIELD", user.loginUsuario);
                updateCommand.ExecuteNonQuery();
                updateTransaction.Commit();
                updateCommand.Dispose();
                close();*/
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public int estadoSesion(Usuario user)
        {
            int estado = 0;
            try
            {
                estado = context.Usuarios.Where(x => x.Login == user.loginUsuario).FirstOrDefault().Habili.Value;
                /* open();
                 String sqlQuery = "SELECT HABILI FROM USUARIOS WHERE LOGIN=@USER_FIELD";
                 FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                 sqlCommand.Parameters.Add("@USER_FIELD", user.loginUsuario);
                 FbDataReader usuariosReader = sqlCommand.ExecuteReader();

                 while (usuariosReader.Read())
                 {
                     estado = usuariosReader.GetInt32(0);
                 }
                 usuariosReader.Close();
                 close();*/
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }
            return estado;
        }

        public Usuario obtenerUsuarioCompleto(Usuario user)
        {
            try
            {
                var usuario = context.Usuarios.Where(x => x.Login == user.loginUsuario).FirstOrDefault();
                Usuario usuarioDto = new Usuario();
                usuarioDto.idUsuario = usuario.Numero;
                usuarioDto.nombre = usuario.Nombre;
                usuarioDto.area = usuario.Area;
                usuarioDto.deposito = usuario.Deposi;
                usuarioDto.loginUsuario = user.loginUsuario;


                /* Usuario usuarioDto = new Usuario();
                 open();
                 String sqlQuery = "SELECT NUMERO, NOMBRE, AREA, DEPOSI FROM USUARIOS WHERE LOGIN=@USER_FIELD";
                 FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                 sqlCommand.Parameters.Add("@USER_FIELD", user.loginUsuario);
                 FbDataReader usuarioReader = sqlCommand.ExecuteReader();

                 while (usuarioReader.Read())
                 {
                     usuarioDto.idUsuario = usuarioReader.GetInt32(0);
                     usuarioDto.nombre = usuarioReader.GetString(1);
                     usuarioDto.area = usuarioReader.GetInt32(2);
                     usuarioDto.deposito = usuarioReader.GetInt32(3);
                     usuarioDto.loginUsuario = user.loginUsuario;
                 }
                 usuarioReader.Close();
                 close();*/
                return usuarioDto;
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }
        }
    }
}

