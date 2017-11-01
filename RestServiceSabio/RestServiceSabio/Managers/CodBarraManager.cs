using FirebirdSql.Data.FirebirdClient;
using RestServiceSabio.DbManager;
using RestServiceSabio.Entities;
using RestServiceSabio.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestServiceSabio.Managers
{
    public class CodBarraManager : DbConnection
    {
        SabioDbContext context = new SabioDbContext();
        public List<CodigoBarra> obtenerTodos()
        {
            try
            {
                List<Tiposcodbarra> listaCodigos = context.Tiposcodbarra.ToList();
                List<CodigoBarra> listadoCodigosDTO = new List<CodigoBarra>();
                foreach (var codigo in listaCodigos)
                {
                    CodigoBarra codigoBarra = new CodigoBarra();
                    codigoBarra.numero = codigo.Numero;
                    codigoBarra.nombre = codigo.Nombre;
                    codigoBarra.descripcion = codigo.Descri;
                    codigoBarra.largoTotal = (int)codigo.Lartot;
                    codigoBarra.ubicacionCodProd = (int)codigo.Ucodpr;
                    codigoBarra.largoCodProd = (int)codigo.Lcodpr;
                    codigoBarra.ubicacionCantidad = (int)codigo.Ubican;
                    codigoBarra.largoCantidad = (int)codigo.Larcan;
                    codigoBarra.ubicacionPrecio = (int)codigo.Ubipre;
                    codigoBarra.largoPrecio = (int)codigo.Larpre;
                    codigoBarra.ubicacionPeso = (int)codigo.Ubipes;
                    codigoBarra.largoPeso = (int)codigo.Larpes;
                    codigoBarra.ubicacionFechaElab = (int)codigo.Ufecel;
                    codigoBarra.largoFechaElab = (int)codigo.Lfecel;
                    codigoBarra.ubicacionFechaVenc = (int)codigo.Ufecve;
                    codigoBarra.largoFechaVenc = (int)codigo.Lfecve;
                    codigoBarra.ubicacionDigitoVer = (int)codigo.Udigve;
                    codigoBarra.largoDigitoVer = (int)codigo.Ldigve;
                    codigoBarra.ubicacionIdUsuario = (int)codigo.Unuser;
                    codigoBarra.largoIdUsuario = (int)codigo.Lnuser;
                    codigoBarra.cantidadDecPeso = (int)codigo.Cantdecpeso;
                    listadoCodigosDTO.Add(codigoBarra);
                }
                return listadoCodigosDTO;
            }
            catch (Exception e)
            { throw new Exception(e.StackTrace.ToString()); }

            //    List<CodigoBarra> listadoCodigos = new List<CodigoBarra>();

            //    try
            //    {
            //        open();
            //        String sqlQuery = "SELECT * FROM TIPOSCODBARRA";
            //        FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
            //        FbDataReader codigosReader = sqlCommand.ExecuteReader();

            //        FbDataReader codigosReader = dbManager.selectSimpleQuery("TIPOSCODBARRA", "*", "", null);
            //        while (codigosReader.Read())
            //        {
            //            CodigoBarra codigoBarra = new CodigoBarra();
            //            codigoBarra.numero = codigosReader.GetInt32(0);
            //            codigoBarra.nombre = codigosReader.GetString(1);
            //            codigoBarra.descripcion = codigosReader.GetString(2);
            //            codigoBarra.largoTotal = codigosReader.GetInt32(3);
            //            codigoBarra.ubicacionCodProd = codigosReader.GetInt32(4);
            //            codigoBarra.largoCodProd = codigosReader.GetInt32(5);
            //            codigoBarra.ubicacionCantidad = codigosReader.GetInt32(6);
            //            codigoBarra.largoCantidad = codigosReader.GetInt32(7);
            //            codigoBarra.ubicacionPrecio = codigosReader.GetInt32(8);
            //            codigoBarra.largoPrecio = codigosReader.GetInt32(9);
            //            codigoBarra.ubicacionPeso = codigosReader.GetInt32(10);
            //            codigoBarra.largoPeso = codigosReader.GetInt32(11);
            //            codigoBarra.ubicacionFechaElab = codigosReader.GetInt32(12);
            //            codigoBarra.largoFechaElab = codigosReader.GetInt32(13);
            //            codigoBarra.ubicacionFechaVenc = codigosReader.GetInt32(14);
            //            codigoBarra.largoFechaVenc = codigosReader.GetInt32(15);
            //            codigoBarra.ubicacionDigitoVer = codigosReader.GetInt32(16);
            //            codigoBarra.largoDigitoVer = codigosReader.GetInt32(17);
            //            codigoBarra.ubicacionIdUsuario = codigosReader.GetInt32(18);
            //            codigoBarra.largoIdUsuario = codigosReader.GetInt32(19);
            //            codigoBarra.cantidadDecPeso = codigosReader.GetInt32(20);
            //            listadoCodigos.Add(codigoBarra);
            //        }
            //        codigosReader.Close();
            //        close();
            //    }
            //    catch (Exception e)
            //    {
            //        throw new Exception(e.StackTrace.ToString());
            //    }

            //}
        }
    }
}