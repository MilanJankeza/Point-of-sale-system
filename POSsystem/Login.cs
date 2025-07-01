using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POSsystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = userTB.Text;
            string password = passTB.Text;

            Authentication auth = new Authentication();
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection= dbConnection.GetConnection();
            if (auth.AuthenticateUser(username, password))
            {connection.Open();
                Home home=new Home();
                using (MySqlCommand cmd = new MySqlCommand("SELECT first_name, CONCAT(LEFT(last_name, 1), '.') AS last_initial, role FROM staff WHERE username = @username", connection))
                {
                    
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["first_name"].ToString();
                            string lastInitial = reader["last_initial"].ToString();
                            string role = reader["role"].ToString();

                            home.NameLB.Text = ""+firstName+" "+lastInitial+"";
                            home.roleLB.Text = role;
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
                
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
