using FirebirdSql.Data.FirebirdClient;

namespace RestServiceSabio.DbManager
{
    public class DbConnection
    {
        public const string connString = "User ID=SYSDBA;Password=masterkey;" +
                       "Database=localhost:C:\\GOLDEN_CL.FDB; " +
                       "DataSource=localhost;Charset=NONE;";
        public FbConnection connection = new FbConnection(connString);

        public void open()
        {
            connection.Open();
        }
        public void close()
        {
            connection.Close();
        }
    }
}
