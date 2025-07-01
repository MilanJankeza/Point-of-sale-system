using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using POSsystem.Control;
using System.Data;

namespace POSsystem
{
    
    internal class MenuDataAccess
    {

        private DatabaseConnection dbConnection;

        public MenuDataAccess()
        {

            dbConnection = new DatabaseConnection();
            dbConnection.OpenConnection();
        }
        public List<MenuItem> GetMenuItemsFromDatabase()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (MySqlCommand cmd = dbConnection.GetConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectMenuItemsWithCategory";
               
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MenuItem menuItem = new MenuItem
                        {
                            Category = reader["category"].ToString(),
                            Name = reader["name"].ToString(),
                            Price = Convert.ToDecimal(reader["price"])
                        };
                        menuItems.Add(menuItem);
                    }
                }
            }

            return menuItems;
        }

    }
}
