using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace POSsystem
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection()
        {
            
            string server = "localhost";
            string database = "pos";
            string userId = "root";
            string password = "";

            string connectionString = $"Server={server};Database={database};User Id={userId};Password={password};";
            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public bool OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                return true;
            }
            catch (MySqlException ex)
            {
               
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
