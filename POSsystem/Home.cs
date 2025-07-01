using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSsystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        DatabaseConnection dbConnection = new DatabaseConnection();

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();
            List<Guna2CircleButton> Tables = this.PanelTable.Controls.OfType<Guna2CircleButton>().ToList();
            MySqlCommand cmd = new MySqlCommand("SELECT table_id FROM orders WHERE order_status_id = 2", connection);
            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int tableid = Convert.ToInt32(reader["table_id"]);
                    

                    Guna2CircleButton button = Tables.FirstOrDefault(b => b.Name.Split('_')[1] == tableid.ToString());

                    if (button != null)
                    {
                       
                        button.FillColor = Color.Red;
                        button.ForeColor = Color.White;

                    }
                }
            }

        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CustomButtonClick(object sender, EventArgs e)
        {
            Order order = new Order();
            string buttonName2 = ((Guna2CircleButton)sender).Name;
            string tableId2 = (buttonName2.Split('_')[1]).ToString();
            int statusId2 = 2;
            int existingorderid = CheckTableStatusAndGetOrderID(tableId2,statusId2);
            if (existingorderid>0)
            {
                order.TableLB.Text = ((Guna2CircleButton)sender).Text;
                order.Show();
            }
            else
            {


                string buttonName = ((Guna2CircleButton)sender).Name;
                string tableId = (buttonName.Split('_')[1]).ToString();
                int statusId = 2;

                using (MySqlCommand cmd = dbConnection.GetConnection().CreateCommand())
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertOrder";
                    cmd.Parameters.Add(new MySqlParameter("@p_table_id", Convert.ToInt32(tableId)));
                    cmd.Parameters.Add(new MySqlParameter("@p_order_status_id", statusId));
                    cmd.ExecuteNonQuery();
                    ((Guna2CircleButton)sender).FillColor = Color.Red;
                    ((Guna2CircleButton)sender).ForeColor = Color.White;
                    order.TableLB.Text = ((Guna2CircleButton)sender).Text;
                    order.Show();
                }
            }



            
            }
        private int CheckTableStatusAndGetOrderID(string tableID, int statusID)
        {
            int orderID = 0;
            MySqlConnection connection = dbConnection.GetConnection();
            dbConnection.OpenConnection();
            
            using (MySqlCommand cmd = new MySqlCommand("SELECT order_id FROM Orders WHERE table_id = @tableID AND order_status_id = @statusID", connection))
            {
                cmd.Parameters.AddWithValue("@tableID", tableID);
                cmd.Parameters.AddWithValue("@statusID", statusID);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        orderID = reader.GetInt32(0);
                        
                    }
                }
            }
            return orderID;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
    
}
