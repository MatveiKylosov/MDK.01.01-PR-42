using System.Data.SqlClient;

namespace ShopContent.Classes
{
    public class Connection
    {
        private static readonly string config = "server = DESKTOP-7K0NDVP;Trusted_Connection=No;DataBase=ShopContent;User=SA;PWD=Asdfg123";
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(config);
            connection.Open();
            return connection;
        }

        public static SqlDataReader Query(string SQL, out SqlConnection connection)
        {
            connection = OpenConnection();
            return new SqlCommand(SQL, connection).ExecuteReader();
        }

        public static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
            SqlConnection.ClearPool(connection);
        }
    }
}
