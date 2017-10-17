using FirebirdSql.Data.FirebirdClient;
using RestServiceSabio.DbManager;
using RestServiceSabio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceSabio.Data
{
    public class CodBarraManager : DbConnection
    {
        public List<CodigoBarra> obtenerTodos()
        {
            List<CodigoBarra> listadoCodigos = new List<CodigoBarra>();

            try
            {
                open();
                String sqlQuery = "SELECT * FROM TIPOSCODBARRA";
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                FbDataReader codigosReader = sqlCommand.ExecuteReader();

                while (codigosReader.Read())
                {
                    CodigoBarra codigoBarra = new CodigoBarra();
                    codigoBarra.numero = codigosReader.GetInt32(0);
                    codigoBarra.nombre = codigosReader.GetString(1);
                    codigoBarra.descripcion = codigosReader.GetString(2);
                    codigoBarra.largoTotal = codigosReader.GetInt32(3);
                    codigoBarra.ubicacionCodProd = codigosReader.GetInt32(4);
                    codigoBarra.largoCodProd = codigosReader.GetInt32(5);
                    codigoBarra.ubicacionCantidad = codigosReader.GetInt32(6);
                    codigoBarra.largoCantidad = codigosReader.GetInt32(7);
                    codigoBarra.ubicacionPrecio = codigosReader.GetInt32(8);
                    codigoBarra.largoPrecio = codigosReader.GetInt32(9);
                    codigoBarra.ubicacionPeso = codigosReader.GetInt32(10);
                    codigoBarra.largoPeso = codigosReader.GetInt32(11);
                    codigoBarra.ubicacionFechaElab = codigosReader.GetInt32(12);
                    codigoBarra.largoFechaElab = codigosReader.GetInt32(13);
                    codigoBarra.ubicacionFechaVenc = codigosReader.GetInt32(14);
                    codigoBarra.largoFechaVenc = codigosReader.GetInt32(15);
                    codigoBarra.ubicacionDigitoVer = codigosReader.GetInt32(16);
                    codigoBarra.largoDigitoVer = codigosReader.GetInt32(17);
                    codigoBarra.ubicacionIdUsuario = codigosReader.GetInt32(18);
                    codigoBarra.largoIdUsuario = codigosReader.GetInt32(19);
                    codigoBarra.cantidadDecPeso = codigosReader.GetInt32(20);
                    listadoCodigos.Add(codigoBarra);
                }
                codigosReader.Close();
                close();
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }
            return listadoCodigos;
        }
    }
}
