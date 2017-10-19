using RestServiceSabio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using RestServiceSabio.DbManager;

namespace RestServiceSabio.Data
{
    public class ComprobantesManager : DbConnection
    {
        public Comprobante obtenerComprobante(Usuario user)
        {
            Comprobante comprobante = new Comprobante();
            List<Item> listadoItems = new List<Item>();
            try
            {
                open();
                String sqlQuery = "SELECT * FROM P_GETPICKING(@ID_USER)";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                sqlCommand.Parameters.Add("@ID_USER", user.idUsuario);

                FbDataReader comprobantesReader = sqlCommand.ExecuteReader();

                while (comprobantesReader.Read())
                {
                    Item item = new Item();

                    comprobante.numeroPick = comprobantesReader.GetInt32(0);
                    comprobante.orden = comprobantesReader.GetInt32(1);
                    comprobante.observaciones = comprobantesReader.GetString(2);
                    comprobante.puedeUsuario = comprobantesReader.GetInt32(3);

                    item.codigoArticulo = comprobantesReader.GetString(4);
                    item.descripcion = comprobantesReader.GetString(5);
                    item.unidad = comprobantesReader.GetInt32(6);
                    item.cantidad = comprobantesReader.GetDouble(7);
                    item.kilos = comprobantesReader.GetDouble(8);
                    item.puedePickear = comprobantesReader.GetDouble(9);
                    item.saldo = comprobantesReader.GetDouble(10);

                    listadoItems.Add(item);
                }
                comprobante.items = listadoItems;
                comprobantesReader.Close();
                close();
            }
            //if (listadoComprobantes.Count > 0)
            //{
            //    registrarPicking(listadoComprobantes);
            //    modificarEstado(listadoComprobantes);
            //}
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }

            if (comprobante.numeroPick != 0 && comprobante.numeroPick != null)
            {
                registrarPickingUser(comprobante, user);
                actualizarEstado(comprobante);
            }
            return comprobante;
        }

        public Boolean registrarPickingUser(Comprobante comprobante, Usuario user)
        {
            Boolean registrado = false;
            try
            {
                open();
                String sqlQuery = "SELECT * FROM PICKING_USER where USUARI = @ID_USER";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                sqlCommand.Parameters.Add("@ID_USER", user.idUsuario);
                FbDataReader idReader = sqlCommand.ExecuteReader();

                if (!idReader.Read())
                {
                    FbTransaction insertTransaction = connection.BeginTransaction();
                    FbCommand insertCommand = new FbCommand();
                    insertCommand.CommandText = "insert into PICKING_USER (NROPIC,USUARI) values" +
                        " (" + comprobante.numeroPick + "," + user.idUsuario + ")";
                    insertCommand.Connection = connection;
                    insertCommand.Transaction = insertTransaction;

                    insertCommand.ExecuteNonQuery();
                    insertTransaction.Commit();
                    insertCommand.Dispose();
                    registrado = true;
                }
                idReader.Close();
                close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
            return registrado;
        }

        public Boolean actualizarEstado(Comprobante comprobante)
        {
            Boolean actualizado = false;
            try
            {
                open();
                FbTransaction updateTransaction = connection.BeginTransaction();
                FbCommand updateCommand = new FbCommand();

                updateCommand.CommandText = "UPDATE PICKING SET ESTADO = @ESTADO WHERE NUMINT = @NUM_PICK";
                updateCommand.Connection = connection;
                updateCommand.Transaction = updateTransaction;
                updateCommand.Parameters.Add("@ESTADO", 2);
                updateCommand.Parameters.Add("@NUM_PICK", comprobante.numeroPick);
                updateCommand.ExecuteNonQuery();
                updateTransaction.Commit();
                updateCommand.Dispose();
                close();
                actualizado = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
            return actualizado;
        }

    }
}
