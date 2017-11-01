using FirebirdSql.Data.FirebirdClient;
using System;


namespace RestServiceSabio.DbManager
{
    public class DbManagerM : DbConnection
    {

        public int getGenerador(String generador)
        {
            open();
            int id = 0;
            String sqlQuery = "SELECT GEN_ID(" + generador + ",0) FROM RDB$DATABASE";
            FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
            FbDataReader idReader = sqlCommand.ExecuteReader();
            while (idReader.Read())
            {
                id = idReader.GetInt32(0);
            }
            idReader.Close();
            close();
            return id;

        }

        public int getSiguienteGenerador(String generador)
        {
            open();
            int id = 0;
            String sqlQuery = "SELECT NEXT VALUE FOR " + generador + " FROM RDB$DATABASE";
            FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
            FbDataReader idReader = sqlCommand.ExecuteReader();
            while (idReader.Read())
            {
                id = idReader.GetInt32(0);
            }
            idReader.Close();
            close();
            return id;
        }


        public FbDataReader selectSimpleQuery(String tabla, String campos, String atributoCondicion, String condicional)
        {
            try
            {
                open();
                String sqlQuery;
                if (condicional == null)
                {
                    sqlQuery = "SELECT " + campos + " FROM " + tabla;
                }
                else
                {
                    sqlQuery = "SELECT " + campos + " FROM " + tabla + "WHERE " + atributoCondicion + "=" + condicional;
                }
                FbCommand sqlCommand = new FbCommand(sqlQuery, connection);
                FbDataReader reader = sqlCommand.ExecuteReader();
                close();
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.StackTrace.ToString());
            }
        }

        public void insertSerialQuery(String tabla, String atributos, params Object[] values)
        {
            open();
            FbTransaction insertTransaction = connection.BeginTransaction();
            FbCommand insertCommand = new FbCommand();
            insertCommand.CommandText = "insert into " + tabla + " (" + atributos + ") values" +
                " (" + values[0] + ",'" + Convert.ToString(values[1]) + "','" + values[2] + "'," + values[3] + "," + 0 + "," + 0 + ")";
            insertCommand.Connection = connection;
            insertCommand.Transaction = insertTransaction;

            insertCommand.ExecuteNonQuery();
            insertTransaction.Commit();
            insertCommand.Dispose();
            close();
        }
    }
}
