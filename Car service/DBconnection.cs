using MySql.Data.MySqlClient;

namespace Car_service
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=aksib.space;username=u0829589_exoum;password=aef10iop;database=u0829589_paintball;charset=utf8mb4");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
