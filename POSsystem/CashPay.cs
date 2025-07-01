using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSsystem
{
    public partial class CashPay : Form
    {
        
        public CashPay()
        {
            InitializeComponent();
        }

        private void CashPay_Load(object sender, EventArgs e)
        {
           
            decimal totalSum = 0;
            int orderid = Convert.ToInt32(OrderIDLB.Text);
            FillDataGridViewWithOrderItems(orderid);
            foreach (DataGridViewRow row in DataTableList.Rows)
            {
                if (row.Cells.Count > 2 && row.Cells[2].Value != null)
                {

                    decimal cellValue = Convert.ToDecimal(row.Cells[2].Value);
                    totalSum += cellValue;
                }
            }
            decimal k = totalSum;
            if (Convert.ToDecimal(SumLB.Text) < k)
            { DiscountRB.Checked = true;
                DiscountRB.Enabled = false;
            }
            else
            {
                DiscountRB.Checked=false;
                DiscountRB.Enabled = false;
            }
            

        }
        private void FillDataGridViewWithOrderItems(int orderID)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable dataTable = new DataTable();

            MySqlConnection connection = dbConnection.GetConnection();

            using (MySqlCommand cmd = new MySqlCommand("GetOrderItemsByOrderID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_order_id", orderID);

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                {
                    dataAdapter.Fill(dataTable);
                }
            }
            DataTableList.DataSource = dataTable;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GivenTB_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(GivenTB.Text, out decimal givenAmount))
            {
                if (givenAmount < Convert.ToDecimal(SumLB.Text))
                {
                    ReturnLB.Text = "0";
                }
                else
                {
                    ReturnLB.Text = (givenAmount - Convert.ToDecimal(SumLB.Text)).ToString();
                }
            }
            else
            {
                MessageBox.Show("Molim vas da unesete validan broj!!!");
            }
        }

        private void PayBT_Click(object sender, EventArgs e)
        {
            //treba da vidim gde cu pisati
        }
    }
}
