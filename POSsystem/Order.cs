using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using POSsystem.Control;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POSsystem
{
    public partial class Order : Form
    {
        public DataGridView DataTableGlobal
        {
            get { return DataTableShow; }
            set { DataTableShow = (DataGridView)value; }
        }
        DatabaseConnection dbConnection = new DatabaseConnection();
        
        public Order()
        {
            InitializeComponent();
            
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();
            MenuDataAccess menuDataAccess = new MenuDataAccess();
            List<MenuItem> menuItems = menuDataAccess.GetMenuItemsFromDatabase();
            foreach (MenuItem menuItem in menuItems)
            {
                MenuItemControl menuItemControl = new MenuItemControl(this);
                menuItemControl.SetMenuItem(menuItem);
                menuitem.Controls.Add(menuItemControl);
            }

            
            try
            {
                connection.Open();

                
                string tableID = (TableLB.Text.Split(' ')[1]).ToString();
                int statusID = 2;
                int orderID = CheckTableStatusAndGetOrderID(tableID, statusID);

                if (orderID > 0)
                {
                 
                    FillDataGridViewWithOrderItems(orderID);
                    OrderIdLB.Text = orderID.ToString();
                }
                else
                {
                    int lastOrderId=GetLastInsertedOrderID();
                    FillDataGridViewWithOrderItems(lastOrderId);
                    OrderIdLB.Text = lastOrderId.ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            decimal totalSum = 0;

            foreach (DataGridViewRow row in DataTableShow.Rows)
            {
                if (row.Cells.Count > 2 && row.Cells[2].Value != null)
                {
                    
                    decimal cellValue = Convert.ToDecimal(row.Cells[2].Value);
                    totalSum += cellValue;
                }
            }
            SumLB.Text = totalSum.ToString();
        }
        private int GetLastInsertedOrderID()
        { 
            MySqlConnection connection = dbConnection.GetConnection();
            using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", connection))
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                connection.Close();
                return Convert.ToInt32(result);
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
        public void FillDataGridViewWithOrderItems(int orderID)
        {
            
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

           
            DataTableShow.DataSource = dataTable;
        }
        private void menuitem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            
            CashPay cp=new CashPay();
            cp.OrderIDLB.Text = OrderIdLB.Text;
            cp.SumLB.Text = SumLB.Text;
            cp.Show();
            this.Close();

        }

        private void CoffeeBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Kafa");

            }
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeaBT_Click(object sender, EventArgs e)
        {
            foreach(var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Caj");

            }
        }

        private void WaterBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Voda");

            }
        }

        private void SodaBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Sok");

            }
        }

        private void FrapeBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Frape");

            }
        }

        private void BeerBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Pivo");

            }
        }

        private void WineBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Vino");

            }
        }

        private void RakijaBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.CategoryLB.ToString().Contains("Rakija");

            }
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.NameLB.Text.ToLower().Contains(SearchTB.Text.Trim());

            }
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            foreach (var item in menuitem.Controls)
            {
                var wdg = (MenuItemControl)item;
                wdg.Visible = wdg.NameLB.Text.ToLower().Contains(SearchTB.Text);

            }
        }

        private void AllBT_Click(object sender, EventArgs e)
        {
            menuitem.Controls.Clear();
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();
            MenuDataAccess menuDataAccess = new MenuDataAccess();
            List<MenuItem> menuItems = menuDataAccess.GetMenuItemsFromDatabase();
            foreach (MenuItem menuItem in menuItems)
            {
                MenuItemControl menuItemControl = new MenuItemControl(this);
                menuItemControl.SetMenuItem(menuItem);
                menuitem.Controls.Add(menuItemControl);
            }
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SumLB_Click(object sender, EventArgs e)
        {

        }

        private void DiscountBT_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();
            if (DiscountTB.Text != "")
            {

                try
                {
                    connection.Open();

                    
                    string discountName = DiscountTB.Text.Trim();
                    decimal discountAmount = GetDiscountAmountFromDB(discountName);
                    if (discountAmount > 0)
                    {

                        decimal totalAmount = decimal.Parse(SumLB.Text);
                        decimal discountedAmount = totalAmount - (totalAmount * (discountAmount / 100));
                        SumLB.Text = discountedAmount.ToString("0.00"); 
                        DiscountBT.Enabled = false;
                    }
                    else { MessageBox.Show("Molim Vas unesite validan discount"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

               
            }
            else
            {
                MessageBox.Show("There must be discount code to press this button");
            }
        }
        private decimal GetDiscountAmountFromDB(string discountName)
        {
            decimal discountAmount = 0;
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();
            
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("GetDiscountAmount", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_discount_name", discountName);

                    cmd.Parameters.Add("@p_discount_amount", MySqlDbType.Decimal);
                    cmd.Parameters["@p_discount_amount"].Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    discountAmount = Convert.ToDecimal(cmd.Parameters["@p_discount_amount"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return discountAmount;
        }

        private void DecrementOrderItemQuantity(int orderId, int itemId)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();

            try
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("DecrementOrderItemQuantity", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_order_id", orderId);
                    cmd.Parameters.AddWithValue("@p_item_id", itemId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void SomeEventOnForm1(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(OrderIdLB.Text);
            FillDataGridViewWithOrderItems(orderId);
        }
        private int GetItemIDByName(string itemName)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();
            connection.Open();
            int itemID = 0;

            using (MySqlCommand cmd = new MySqlCommand("SELECT item_id FROM menuitems WHERE item_name = @itemName", connection))
            {
                cmd.Parameters.AddWithValue("@itemName", itemName);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    itemID = Convert.ToInt32(result);

                }
            }

            return itemID;
        }
        private void ClearSBT_Click(object sender, EventArgs e)
        {
            if (DataTableShow.SelectedRows.Count > 0)
            {

                int selectedIndex = DataTableShow.SelectedRows[0].Index;


                string itemname = Convert.ToString(DataTableShow.Rows[selectedIndex].Cells[0].Value);

                
                int orderId = Convert.ToInt32(OrderIdLB.Text);
                int itemID = GetItemIDByName(itemname);
                
                DecrementOrderItemQuantity(orderId,itemID);
                FillDataGridViewWithOrderItems(orderId);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView before using this button.");
            }
            
            

        }

        private void ClearLastBT_Click(object sender, EventArgs e)
        {
            if (DataTableShow.Rows.Count > 1)
            {
                int lastRowIndex = DataTableShow.Rows.Count - 2;
                DataTableShow.Rows[lastRowIndex].Selected = true;
                string itemname = Convert.ToString(DataTableShow.Rows[lastRowIndex].Cells[0].Value);


                int orderId = Convert.ToInt32(OrderIdLB.Text);
                int itemID = GetItemIDByName(itemname);

                DecrementOrderItemQuantity(orderId, itemID);
                FillDataGridViewWithOrderItems(orderId);
            }
            else
            {
                MessageBox.Show("Table is empty.");
            }
        }
    }
}
