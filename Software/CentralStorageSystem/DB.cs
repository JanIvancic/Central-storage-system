using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralStorageSystem
{
    internal class DB
    {
        private static string _connectionString = @"Data Source=31.147.204.119\PISERVER,1433; User=jivancic20; Password='}@*V;?/h'; Database=jivancic20_DB";
        private static SqlConnection _connection;
        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }
        public static void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }
        public static int ExecuteCommand(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, _connection);
            return command.ExecuteNonQuery();
        }

    }
}
