using RestServiceSabio.Model;
using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using RestServiceSabio.DbManager;
using RestServiceSabio.Entities;
using System.Linq;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace RestServiceSabio.Managers
{
    public class ComprobantesManager : DbConnection
    {
        SabioDbContext context = new SabioDbContext();
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
                foreach (Item it in listadoItems)
                {
                    List<Serial> serialesL = new List<Serial>();
                    Serial serial = new Serial();
                    for (int i = 1; i <= it.cantidad; i++)
                    {
                        it.seriales = serialesL;
                        it.seriales.Add(serial);
                    }
                }

                comprobante.items = listadoItems;
                comprobantesReader.Close();
                close();
            }
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

        public Boolean guardarStock(Usuario user, Comprobante stock)
        {
            int idMovArt = 0, idMovDetArt = 0;
            Boolean stockCompleto = false;
            Comprobante stockDto = new Comprobante();
            List<Item> articulos = new List<Item>();
            try
            {
                stockDto.numeroPick = stock.numeroPick;
                stockDto.observaciones = stock.observaciones;
                foreach (Item articuloL in stock.items)
                {
                    Item articulo = new Item();
                    List<Serial> seriales = new List<Serial>();
                    articulo.descripcion = articuloL.descripcion;
                    articulo.codigoArticulo = articuloL.codigoArticulo;
                    articulo.cantidad = articuloL.cantidad;
                    articulo.kilos = articuloL.kilos;
                    foreach (Serial serial in articuloL.seriales)
                    {
                        Serial s = new Serial();
                        s.numero = serial.numero;
                        //Chequeo previo si el serial ya existe en la tabla SERIALES
                        if (!existeSerial(s.numero))
                        {
                            //Insert de los seriales en la BD
                            insertarSeriales(s.numero, articulo.codigoArticulo);
                        }
                        s.idSerial = buscarIdSerial(s.numero);
                        seriales.Add(s);
                    }
                    articulo.seriales = seriales;
                    articulos.Add(articulo);
                }
                stockDto.items = articulos;

                //Asigno el ID del movimiento para usarlo posteriormente en el detalle
                idMovArt = insertarMovArticulo(user, stockDto.observaciones);
                if (idMovArt > 0)
                {
                    foreach (Item art in stockDto.items)
                    {
                        idMovDetArt = insertarDetalleMovArticulo(idMovArt, art);
                        foreach (Serial s in art.seriales)
                        {
                            insertarMovSerialesArt(idMovDetArt, s.idSerial);
                        }
                    }
                }
                stockCompleto = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
            return stockCompleto;
        }

        public Boolean guardarComprobanteES(Usuario user, Comprobante stock)
        {
            Boolean stockCompleto = false;
            Comprobante stockDto = new Comprobante();
            List<Item> articulos = new List<Item>();
            try
            {
                stockDto.numeroPick = stock.numeroPick;
                stockDto.observaciones = stock.observaciones;
                stockDto.orden = stock.orden;
                stockDto.puedeUsuario = stock.puedeUsuario;
                foreach (Item articuloL in stock.items)
                {

                    Item articulo = new Item();
                    List<Serial> seriales = new List<Serial>();
                    articulo.descripcion = articuloL.descripcion;
                    articulo.codigoArticulo = articuloL.codigoArticulo;
                    articulo.cantidad = articuloL.cantidad;
                    articulo.kilos = articuloL.kilos;
                    articulo.unidad = articuloL.unidad;
                    articulo.saldo = articuloL.saldo;
                    foreach (Serial serial in articuloL.seriales)
                    {
                        MovContable movC = new MovContable();
                        Serial s = new Serial();
                        s.numero = serial.numero;
                        //Chequeo previo si el serial ya existe en la tabla SERIALES
                        if (!existeSerial(s.numero))
                        {
                            //Insert de los seriales en la BD
                            insertarSeriales(s.numero, articulo.codigoArticulo);
                        }
                        s.idSerial = buscarIdSerial(s.numero);
                        seriales.Add(s);
                    }
                    articulo.seriales = seriales;
                    articulos.Add(articulo);


                    var query = (from a in context.Detmovnoconart
                                 join b in context.Movnocontables on a.Numero equals b.Numint
                                 join c in context.PickingNocon on b.Numint equals c.Nocont
                                 join f in context.Picking on c.Nropic equals f.Numint
                                 where a.Codart == articulo.codigoArticulo && c.Nropic == stockDto.numeroPick
                                 select new
                                 {
                                     Numero = a.Numint,
                                     Cantidad = a.Cantid,
                                     MovCon = a.Numero

                                 }).ToList();

                    List<Serial> listaSerialesMovNoCon = articulo.seriales;
                    foreach (var e in query)
                    {
                        int hasta = Convert.ToInt32(e.Cantidad);
                        List<Serial> serialesInsertar = listaSerialesMovNoCon.Take(hasta).ToList();

                        foreach (Serial s in serialesInsertar)
                        {
                            int chequeoIdSerial = context.Movserialesnocon.Where(x => x.Nroser == s.idSerial).Select(y => y.Nroser).FirstOrDefault();
                            if (e.Numero != 0 && chequeoIdSerial == 0)
                            {
                                insertarMovSerialesNoCon(e.Numero, s.idSerial);

                            }
                            listaSerialesMovNoCon.Remove(s);

                            double cantidad = 0, presen = 0;
                            if (s.numero.Length == 26)
                            {
                                if (articuloL.unidad == 1)
                                {
                                    cantidad = articuloL.kilos;
                                    presen = e.Cantidad;

                                }
                                else
                                {
                                    cantidad = e.Cantidad;
                                    presen = articuloL.kilos;
                                }
                                actualizarKilosDetmovNoCont(e.Numero, cantidad, presen);

                            }

                        }
                        actualizarEstadoMovNoCon(e.MovCon);
                    }
                }
                stockDto.items = articulos;
                stockCompleto = true;
                actualizarEstadoPicking(stockDto.numeroPick, 3);
                return stockCompleto;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                e.StackTrace.ToString();
                return stockCompleto;
            }

        }

        public Boolean actualizarKilosDetmovNoCont(int idMovNoCon, double cantidad, double presen)
        {
            try
            {
                context.Detmovnoconart.Where(x => x.Numint == idMovNoCon).ToList().ForEach(y => y.Cantid = cantidad);
                context.Detmovnoconart.Where(x => x.Numint == idMovNoCon).ToList().ForEach(y => y.Presen = presen);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString(), e.InnerException);
            }
        }
        public Boolean actualizarEstadoPicking(int? numeroPick, int estado)
        {
            try
            {
                context.Picking.Where(x => x.Numint == numeroPick).ToList().ForEach(y => y.Estado = estado);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString(), e.InnerException);
            }
        }

        public Boolean actualizarEstadoMovNoCon(int numeroMovNoCon)
        {
            try
            {
                context.Movnocontables.Where(x => x.Numint == numeroMovNoCon).ToList().ForEach(y => y.Estado = 2);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString(), e.InnerException);
            }

        }

        public Boolean esNoContable(int noCont)
        {
            int numero = context.Detmovnoconart.First(x => x.Numero == noCont).Numero;
            Boolean esNoCont = false;
            if (!String.IsNullOrEmpty(numero.ToString()) && numero > 0)
            {
                esNoCont = true;
            }
            return esNoCont;
        }

        public Boolean insertarMovSerialesNoCon(int noCont, int idSerial)
        {
            try
            {
                /*Movserialesnocon movNoCont = new Movserialesnocon();
                movNoCont.Nocont = noCont;
                movNoCont.Nroser = idSerial;
                context.Movserialesnocon.Add(movNoCont);
                context.SaveChanges();*/
                open();
                FbTransaction insertTransaction = connection.BeginTransaction();
                FbCommand insertCommand = new FbCommand();
                insertCommand.CommandText = "insert into MOVSERIALESNOCON (NOCONT,NROSER) values" +
                    " (" + noCont + "," + idSerial + ")";
                insertCommand.Connection = connection;
                insertCommand.Transaction = insertTransaction;

                insertCommand.ExecuteNonQuery();
                insertTransaction.Commit();
                insertCommand.Dispose();
                close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString(), e.InnerException);
            }
            return true;
        }

        public Boolean insertarSeriales(String serial, String codArt)
        {
            try
            {
                int id = 0;
                int proveedor = 0;
                open();
                String sqlQuery = "select next value for GEN_SERIALES from RDB$DATABASE";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                FbDataReader idReader = sqlCommand.ExecuteReader();

                while (idReader.Read())
                {
                    id = idReader.GetInt32(0);
                }
                idReader.Close();

                String sqlQueryParam = "select BOOLE1 FROM PARAMETROS where CODIGO='DROIDPROVE'";
                FbCommand sqlCommandParam = new FbCommand(sqlQueryParam, connection);
                FbDataReader provedorReader = sqlCommandParam.ExecuteReader();

                while (provedorReader.Read())
                {
                    proveedor = provedorReader.GetInt32(0);
                }
                provedorReader.Close();

                FbTransaction insertTransaction = connection.BeginTransaction();
                FbCommand insertCommand = new FbCommand();
                insertCommand.CommandText = "insert into SERIALES (NUMINT,SERIAL,CODART,PROVEE,GTACOM,GTAVTA) values" +
                    " (" + id + ",'" + serial + "','" + codArt + "'," + proveedor + "," + 0 + "," + 0 + ")";
                insertCommand.Connection = connection;
                insertCommand.Transaction = insertTransaction;

                insertCommand.ExecuteNonQuery();
                insertTransaction.Commit();
                insertCommand.Dispose();
                close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }

        }

        public Boolean existeSerial(String serial)
        {
            try
            {
                open();
                String sqlQuery = "SELECT CODART FROM SERIALES WHERE SERIAL=@SERIAL";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                sqlCommand.Parameters.Add("@SERIAL", serial);
                FbDataReader serialReader = sqlCommand.ExecuteReader();

                while (serialReader.Read())
                {
                    close();
                    return true;
                }
                serialReader.Close();
                close();
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public int insertarMovArticulo(Usuario user, String observaciones)
        {
            try
            {
                String codComprobante = "";
                String nroComCompleto = "";
                int nroComprobante = 0;
                int id = 0;
                open();
                String sqlQuery = "select next value for GEN_NUM_MOV_ARTICULOS from RDB$DATABASE";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                FbDataReader idReader = sqlCommand.ExecuteReader();

                while (idReader.Read())
                {
                    id = idReader.GetInt32(0);
                }
                idReader.Close();

                nroComprobante = obtenerNumeroComprobante();
                codComprobante = obtenerCodigoComprobante();

                nroComCompleto = "0001" + Convert.ToString(nroComprobante) + "0000X";


                FbTransaction insertTransaction = connection.BeginTransaction();
                FbCommand insertCommand = new FbCommand();
                insertCommand.CommandText = "insert into MOV_ARTICULOS (NROINT,FECHA,COMPRO,NROCOM,DEPOSI,OBSERV,RESPON,NROCON,INTDEP,NRODEP) values" +
                    " (" + id + "," + "CURRENT_TIMESTAMP" + ",'" + codComprobante + "','" + nroComCompleto + "',"
                    + user.deposito + ",'" + observaciones + "'," + user.idUsuario + "," + id + ","
                    + id + "," + user.deposito + ")";
                insertCommand.Connection = connection;
                insertCommand.Transaction = insertTransaction;

                insertCommand.ExecuteNonQuery();
                insertTransaction.Commit();
                insertCommand.Dispose();
                close();
                return id;
            }
            catch (Exception e)
            {
                return 0;
                throw new Exception(e.Message.ToString());
            }

        }

        public int insertarDetalleMovArticulo(int idMovArt, Item articulo)
        {
            try
            {
                int id = 0;
                open();
                String sqlQuery = "select next value for GEN_NUM_DET_MOV_ARTICULOS from RDB$DATABASE";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                FbDataReader idReader = sqlCommand.ExecuteReader();

                while (idReader.Read())
                {
                    id = idReader.GetInt32(0);
                }
                idReader.Close();

                FbTransaction insertTransaction = connection.BeginTransaction();
                FbCommand insertCommand = new FbCommand();
                insertCommand.CommandText = "insert into DET_MOV_ARTICULOS (NUMERO,NROINT,ARTICU,CANTID,CTRCOM,TRANID,STKFIS) values" +
                    " (" + id + "," + idMovArt + ",'" + articulo.codigoArticulo + "'," + articulo.cantidad + ","
                    + id + "," + 0 + "," + 0 + ")";
                insertCommand.Connection = connection;
                insertCommand.Transaction = insertTransaction;

                insertCommand.ExecuteNonQuery();
                insertTransaction.Commit();
                insertCommand.Dispose();
                close();
                return id;
            }
            catch (Exception e)
            {
                return 0;
                throw new Exception(e.Message.ToString());
            }
        }

        public int buscarIdSerial(String numero)
        {
            try
            {
                int id = 0;
                open();
                String sqlQuery = "SELECT NUMINT FROM SERIALES WHERE SERIAL=@SERIAL";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                sqlCommand.Parameters.Add("@SERIAL", numero);
                FbDataReader idReader = sqlCommand.ExecuteReader();

                while (idReader.Read())
                {
                    id = idReader.GetInt32(0);
                }
                idReader.Close();
                close();
                return id;
            }
            catch (Exception e)
            {
                return 0;
                throw new Exception(e.Message.ToString());
            }
        }

        public Boolean insertarMovSerialesArt(int idMovDetArt, int idSerial)
        {
            try
            {
                open();
                FbTransaction insertTransaction = connection.BeginTransaction();
                FbCommand insertCommand = new FbCommand();
                insertCommand.CommandText = "insert into MOVSERIALESART (MOVART,NROSER) values" +
                    " (" + idMovDetArt + "," + idSerial + ")";
                insertCommand.Connection = connection;
                insertCommand.Transaction = insertTransaction;

                insertCommand.ExecuteNonQuery();
                insertTransaction.Commit();
                insertCommand.Dispose();
                close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString());
            }
        }

        public String obtenerCodigoComprobante()
        {
            String codComprobante = "";
            String sqlQueryParam = "select TEXTO1 FROM PARAMETROS where CODIGO='DROIDCOMP'";
            FbCommand sqlCommandParam = new FbCommand(sqlQueryParam, connection);
            FbDataReader comprobanteReader = sqlCommandParam.ExecuteReader();

            while (comprobanteReader.Read())
            {
                codComprobante = comprobanteReader.GetString(0);
            }
            comprobanteReader.Close();
            return codComprobante;
        }

        public int obtenerNumeroComprobante()
        {
            int id = 0;
            String nombreGenerador = "";
            String sqlQueryParam = "select TEXTO2 FROM PARAMETROS where CODIGO='DROIDCOMP'";
            FbCommand sqlCommandParam = new FbCommand(sqlQueryParam, connection);
            FbDataReader comprobanteReader = sqlCommandParam.ExecuteReader();

            while (comprobanteReader.Read())
            {
                nombreGenerador = comprobanteReader.GetString(0);
            }

            String sqlQuery = "select next value for " + nombreGenerador + " from RDB$DATABASE";
            FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
            FbDataReader idReader = sqlCommand.ExecuteReader();

            while (idReader.Read())
            {
                id = idReader.GetInt32(0);
            }
            idReader.Close();

            return id;
        }
    }
}
