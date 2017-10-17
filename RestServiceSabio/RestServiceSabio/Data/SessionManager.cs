using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System.Collections.Sequences;
using RestServiceSabio.DbManager;
using System.Data;
using RestServiceSabio.Model;

namespace RestServiceSabio.Data
{
    public class SessionManager : DbConnection
    {
        public List<Usuario> obtenerListadoUsuarios()
        {
            List<Usuario> listadoUsuarios = new List<Usuario>();
            try
            {
                open();
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
                close();
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }
            return listadoUsuarios;
        }


        public bool logIn(Usuario user)
        {
            List<Usuario> listadoUsuarios = obtenerListadoUsuarios();

            foreach (Usuario usuario in listadoUsuarios)
            {
                if (user.loginUsuario == usuario.loginUsuario)
                {
                    //Modificar el atributo HABILI a 1
                    modificarEstado(usuario, "ANDROIDIN");
                    //Loguear en LOGS
                    auditoriaLog(usuario, "ANDROIDIN");
                    return true;
                }
            }
            return false;
        }

        public bool logOut(Usuario user)
        {
            List<Usuario> listadoUsuarios = obtenerListadoUsuarios();

            foreach (Usuario usuario in listadoUsuarios)
            {
                if (user.loginUsuario == usuario.loginUsuario)
                {
                    //Modificar el atributo HABILI a 0
                    modificarEstado(usuario, "ANDROIDOUT");
                    //Loguear en LOGS
                    auditoriaLog(usuario, "ANDROIDOUT");
                    return true;
                }
            }
            return false;
        }

        public void auditoriaLog(Usuario user, String operacion)
        {
            try
            {
                int id = 0;
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
                insertCommand.CommandText = "insert into LOGS (NUMERO,CASOUS,FECHA,USUARI,WINUSE,WINNET) values" +
                    " (" + id + ",'" + operacion + "'," + "CURRENT_TIMESTAMP" + "," + user.idUsuario + "," + "'USUARIO'" + "," + "'APPMOVIL'" + ")";
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
                open();
                FbTransaction updateTransaction = connection.BeginTransaction();
                FbCommand updateCommand = new FbCommand();

                updateCommand.CommandText = "UPDATE USUARIOS SET HABILI = @OP_ID WHERE LOGIN = @USER_FIELD";
                updateCommand.Connection = connection;
                updateCommand.Transaction = updateTransaction;

                switch (operacion)
                {
                    case "ANDROIDIN":
                        updateCommand.Parameters.Add("@OP_ID", true);
                        break;
                    case "ANDROIDOUT":
                        updateCommand.Parameters.Add("@OP_ID", false);
                        break;
                }

                updateCommand.Parameters.Add("@USER_FIELD", user.loginUsuario);
                updateCommand.ExecuteNonQuery();
                updateTransaction.Commit();
                updateCommand.Dispose();
                close();
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
                open();
                String sqlQuery = "SELECT HABILI FROM USUARIOS WHERE LOGIN=@USER_FIELD";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                sqlCommand.Parameters.Add("@USER_FIELD", user.loginUsuario);
                FbDataReader usuariosReader = sqlCommand.ExecuteReader();

                while (usuariosReader.Read())
                {
                    estado = usuariosReader.GetInt32(0);
                }
                usuariosReader.Close();
                close();
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }
            return estado;
        }
    }
}

