using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace POSsystem
{
    internal class Authentication
    {
        private DatabaseConnection dbConnection;

        public Authentication()
        {
            
            dbConnection = new DatabaseConnection();
        }

        public bool AuthenticateUser(string username, string password)
        {
            
            string query = "SELECT * FROM staff WHERE Username = @username AND Password = @password";
            using (MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                dbConnection.OpenConnection();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        
                        dbConnection.CloseConnection();
                        return true;
                    }
                }

                dbConnection.CloseConnection();
                return false;
            }
        }
    }
}
