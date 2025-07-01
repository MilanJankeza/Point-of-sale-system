using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSsystem.Control
{
    public partial class MenuItemControl : UserControl
    {
        public string OrderLB
        {
            get
            {
                
                if (this.ParentForm is Order order)
                {
                    return order.OrderIdLB.Text; 
                }
                return string.Empty;
            }
        }
        Order order;
        public MenuItemControl(Order order)
        {
            InitializeComponent();
            
        }
        public void SetMenuItem(MenuItem menuItem)
        {
            CategoryLB.Text = menuItem.Category;
            NameLB.Text = menuItem.Name;
            PriceLB.Text = menuItem.Price.ToString();
        }
        
        private void NameLB_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();
            string itemName = NameLB.Text;
           
            try
            {
                connection.Open();               
                DataTable dt = new DataTable();
                Order order = new Order();


                int itemID = GetItemIDByName(itemName);
                int orderid = Convert.ToInt32(OrderLB);
                int quantity = 1;
                

                if (itemID > 0)
                {
                   
                    InsertOrderItem(orderid,itemID,quantity);
                    
                    decimal totalSum = 0;
                    foreach (DataGridViewRow row in order.DataTableShow.Rows)
                    {
                        if (row.Cells.Count > 2 && row.Cells[2].Value != null)
                        {
                            decimal cellValue = Convert.ToDecimal(row.Cells[2].Value);
                            totalSum += cellValue;
                        }
                    }
                    order.SumLB.Text = totalSum.ToString();
                }
                else
                {
                    MessageBox.Show("Item not found.");
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
        //public void FillDataGridViewWithOrderItems(int orderID)
        //{
        //    DatabaseConnection dbConnection = new DatabaseConnection();
        //    Order order = new Order();
        //    DataTable dataTable = new DataTable();

        //    MySqlConnection connection = dbConnection.GetConnection();

        //    using (MySqlCommand cmd = new MySqlCommand("GetOrderItemsByOrderID", connection))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@p_order_id", orderID);

        //        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
        //        {
        //            dataAdapter.Fill(dataTable);
        //        }
        //    }
        //    order.DataTableGlobal.DataSource = dataTable;
        //    order.DataTableGlobal.Refresh();
        //}
        private void InsertOrderItem(int orderId, int itemId, int quantity)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();

            try
            {
                connection.Open();

                
                int existingQuantity = GetOrderItemQuantity(orderId, itemId);

                if (existingQuantity > 0)
                {
                    
                    UpdateOrderItemQuantity(orderId, itemId, existingQuantity + quantity);
                }
                else
                {
                    
                    using (MySqlCommand cmd = new MySqlCommand("InsertOrderItem", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_order_id", orderId);
                        cmd.Parameters.AddWithValue("@p_item_id", itemId);
                        cmd.Parameters.AddWithValue("@p_quantity", quantity);

                        cmd.ExecuteNonQuery();
                    }
                }
                order?.SomeEventOnForm1(this, EventArgs.Empty);

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

        private int GetOrderItemQuantity(int orderId, int itemId)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();

            try
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT quantity FROM orderitems WHERE order_id = @orderId AND item_id = @itemId", connection))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@itemId", itemId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
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

            return 0;
        }

        private void UpdateOrderItemQuantity(int orderId, int itemId, int newQuantity)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            MySqlConnection connection = dbConnection.GetConnection();

            try
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("UPDATE orderitems SET quantity = @quantity WHERE order_id = @orderId AND item_id = @itemId", connection))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    cmd.Parameters.AddWithValue("@quantity", newQuantity);

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
    }
}
