using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C868.Models;

namespace C868
{
    public partial class OrderForm : Form
    {
        bool newOrder;
        int oId;

        public DataTable cartDataTable = new DataTable();

        public OrderForm(bool isNew, int orderId)
        {
            newOrder = isNew;
            oId = orderId;

            InitializeComponent();
            LoadForm(oId);
            LoadCart();
            LoadPicker();
        }

        private void LoadForm(int ordID)
        {
            OrderDateTimePicker.Value = DateTime.Now;

            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();

            if (newOrder == false)
            {
                Order loadOrder = null;

                string query0 = "SELECT OrderId, date(OrderDate), CustName, CustPhone, CustEmail, OrderTotal FROM Orders WHERE OrderId = @Id";
                SQLiteCommand ordCmd = new SQLiteCommand(query0, conn);
                ordCmd.Parameters.AddWithValue("@Id", ordID);

                using (SQLiteDataReader reader = ordCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["OrderId"]);
                        DateTime date = Convert.ToDateTime(reader["date(OrderDate)"]);
                        string name = reader["CustName"].ToString();
                        string phone = reader["CustPhone"].ToString();
                        string email = reader["CustEmail"].ToString();
                        decimal total = Convert.ToDecimal(reader["OrderTotal"]);

                        loadOrder = new Order(id, date, name, phone, email, total);

                        OrderIdText.Text = loadOrder.OrderId.ToString();
                        OrderDateTimePicker.Value = loadOrder.OrderDate;
                        CustNameText.Text = loadOrder.CustName.ToString();
                        CustPhoneText.Text = loadOrder.CustPhone.ToString();
                        CustEmailText.Text = loadOrder.CustEmail.ToString();
                    }
                    reader.Close();
                }
                DeleteBtn.Visible = true;
            }
            else
            {
                DeleteBtn.Visible = false;
            }
            conn.Close();
        }

        private void LoadCart()
        {
            cartDataTable.Clear();
            cartDataTable.Columns.Clear();
            if (!cartDataTable.Columns.Contains("ProdID")) { cartDataTable.Columns.Add("ProdID", typeof(int)); }
            if (!cartDataTable.Columns.Contains("ProdName")) { cartDataTable.Columns.Add("ProdName", typeof(string)); }
            if (!cartDataTable.Columns.Contains("ProdPrice")) { cartDataTable.Columns.Add("ProdPrice", typeof(decimal)); }
            if (!cartDataTable.Columns.Contains("ProdQty")) { cartDataTable.Columns.Add("ProdQty", typeof(int)); }

            if (newOrder == false)
            {
                int currentOrderId = Convert.ToInt32(OrderIdText.Text);

                SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
                conn.Open();

                string query1 =
                    "SELECT Product.ProdID, Product.ProdName, Product.ProdPrice, OrderItems.ProdQty " +
                    "FROM OrderItems " +
                    "INNER JOIN Product " +
                    "ON OrderItems.ProductId = Product.ProdId " +
                    "WHERE OrderItems.OrderId = @Id;";
                SQLiteCommand cartCmd = new SQLiteCommand(query1, conn);
                cartCmd.Parameters.AddWithValue("@Id", currentOrderId);

                SQLiteDataAdapter prodAdapter = new SQLiteDataAdapter(cartCmd);
                prodAdapter.Fill(cartDataTable);

                ProductCartDGV.DataSource = cartDataTable;

                UpdateTotal();

                conn.Close();
            }
        }

        private void LoadPicker()
        {
            BindingList<Product> picker = new BindingList<Product>();

            Product loadProd = null;

            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();

            string query1 = "SELECT ProdId, ProdName, ProdPrice, ProdSKU, Quantity FROM Product";
            SQLiteCommand prodCmd = new SQLiteCommand(query1, conn);

            using (SQLiteDataReader reader = prodCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    loadProd = new Product(
                        Convert.ToInt32(reader["ProdId"]),
                        reader["ProdName"].ToString(),
                        reader["ProdSKU"].ToString(),
                        Convert.ToDecimal(reader["ProdPrice"]), 
                        Convert.ToInt32(reader["Quantity"])
                        );

                    picker.Add(loadProd);
                }
                reader.Close();
            }

            ProdPicker.ValueMember = null;
            ProdPicker.DisplayMember = "ProdName";
            ProdPicker.DataSource = picker;

            conn.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool exists = false;

            Product prod = (Product)ProdPicker.SelectedItem;

            foreach (DataRow row in cartDataTable.Rows)
            {
                int existProd = (int)row["ProdId"];

                if (prod.ProdID == existProd)
                {
                    int qty = (int)row["ProdQty"];
                    qty++;
                    row["ProdQty"] = qty;
                    exists = true;
                }
            }

            if (exists == false)
            {
                cartDataTable.Rows.Add(prod.ProdID, prod.ProdName, prod.ProdPrice, 1);
            }

            ProductCartDGV.DataSource = cartDataTable;
            UpdateTotal();
        }

        private void RemoveBtn_Click(object sender, EventArgs e) // this needs to not edit the database but edit the datatable
        {
            if (ProductCartDGV.RowCount > 0)
            {
                int cartItemId = Convert.ToInt32(ProductCartDGV.SelectedRows[0].Cells[0].Value);

                foreach (DataRow row in cartDataTable.Rows)
                {
                    if (cartItemId == Convert.ToInt32(row["ProdId"]))
                    {
                        int updateQty = Convert.ToInt32(row["ProdQty"]) - 1;
                        row["ProdQty"] = updateQty;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an Order you would like to update.");
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal subtotal = 0;

            foreach (DataRow row in cartDataTable.Rows)
            {
                subtotal = subtotal + (Convert.ToDecimal(row["ProdPrice"]) * Convert.ToDecimal(row["ProdQty"]));
            }

            SubTotalText.Text = subtotal.ToString();

            decimal tax = (subtotal * 7.15m ) / 100;

            TaxText.Text = tax.ToString();

            TotalPriceText.Text = (subtotal + tax).ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int currentOrderId = Convert.ToInt32(OrderIdText.Text);

            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();

            string query1 = "DELETE FROM Orders WHERE OrderId = @ID";
            SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@ID", currentOrderId);

            string query2 = "DELETE FROM OrderItems WHERE OrderId = @ID";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@ID", currentOrderId);

            cmd2.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }

        private void SaveCart(int orderId)
        {
            QtyByProductId newQty = null;
            List<QtyByProductId> oldCart = new List<QtyByProductId>();
            List<QtyByProductId> newCartPlusOldCart = new List<QtyByProductId>();
            QtyByProductId UpdatedItem = null;

            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();

            if (newOrder == true)
            {
                foreach (DataRow row in cartDataTable.Rows) //Get ProdCurrentQTY - Cart
                {
                    string query4 = "SELECT Quantity FROM Product WHERE ProdId = @pID";
                    SQLiteCommand cmd4 = new SQLiteCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@pID", row["ProdId"]);

                    int qty = Convert.ToInt32(cmd4.ExecuteScalar()) - Convert.ToInt32(row["ProdQty"]);

                    string query2 = "UPDATE Product SET Quantity = @qty WHERE ProdId = @pId";
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@qty", qty);
                    cmd2.Parameters.AddWithValue("@pId", row["ProdId"]);
                    cmd2.ExecuteNonQuery();
                }
            }
            else // if it is not a new order. ProdCurrentQTY = ProdCurrentQTY - (NewCart - OldCart)
            {
                string query3 = "SELECT ProductId, ProdQty FROM OrderItems WHERE OrderId = @id"; // OldCart
                SQLiteCommand cmd3 = new SQLiteCommand(query3, conn);
                cmd3.Parameters.AddWithValue("@id", orderId);

                using (SQLiteDataReader reader = cmd3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        newQty = new QtyByProductId(
                            Convert.ToInt32(reader["ProductId"]),
                            Convert.ToInt32(reader["ProdQty"])
                            );

                        oldCart.Add(newQty);
                    }
                    reader.Close();
                }

                foreach (DataRow row in cartDataTable.Rows) // (NewCart - OldCart)
                {
                    foreach(QtyByProductId qty in oldCart) 
                    {
                        if (qty.ProductId == Convert.ToInt32(row["ProdId"]))
                        {
                            int updateqty = Convert.ToInt32(row["ProdQty"]) - qty.ProdQty;
                            UpdatedItem = new QtyByProductId(qty.ProductId, updateqty);
                            newCartPlusOldCart.Add(UpdatedItem);
                        }
                        else
                        {
                            UpdatedItem = new QtyByProductId(qty.ProductId, Convert.ToInt32(row["ProdQty"]));
                            newCartPlusOldCart.Add(UpdatedItem);
                        }
                    }
                }
            }

            foreach (QtyByProductId item in newCartPlusOldCart) // UpdateQty = CurrentQTY - (NewCart - OldCart)
            {
                string query5 = "SELECT Quantity FROM Product WHERE ProdId = @pID";
                SQLiteCommand cmd5 = new SQLiteCommand(query5, conn);
                cmd5.Parameters.AddWithValue("@pID", item.ProductId);

                int CurrentQTY = Convert.ToInt32(cmd5.ExecuteScalar());
                int NewMinusOld = item.ProdQty;
                int UpdateQty = CurrentQTY - NewMinusOld;

                string query6 = "UPDATE Product SET Quantity = @qty WHERE ProdId = @pId";
                SQLiteCommand cmd6 = new SQLiteCommand(query6, conn);
                cmd6.Parameters.AddWithValue("@qty", UpdateQty);
                cmd6.Parameters.AddWithValue("@pId", item.ProductId);
                cmd6.ExecuteNonQuery();
            }

            string query0 = "DELETE FROM OrderItems WHERE OrderId = @ID"; //Drops old cart and adds new cart in OrderItems Database
            SQLiteCommand cmd0 = new SQLiteCommand(query0, conn);
            cmd0.Parameters.AddWithValue("@ID", orderId);
            cmd0.ExecuteNonQuery();

            foreach (DataRow row in cartDataTable.Rows)
            {
                string query1 = "INSERT INTO OrderItems (OrderId, ProductId, ProdQty) " +
                "VALUES (@order, @product, @qty)"; ;
                SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
                cmd1.Parameters.AddWithValue("@order", orderId);
                cmd1.Parameters.AddWithValue("@product", row["ProdId"]);
                cmd1.Parameters.AddWithValue("@qty", row["ProdQty"]);

                cmd1.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            UpdateTotal();
            string custName = CustNameText.Text;
            decimal orderTotal = Convert.ToDecimal(TotalPriceText.Text);

            if (string.IsNullOrWhiteSpace(custName))
            {
                MessageBox.Show("Customer Name cannot be blank.");
            }
            else if (orderTotal == 0)
            {
                MessageBox.Show("This order does not contain any items.");
            }
            else
            {
                string custPhone = CustPhoneText.Text;
                string custEmail = CustEmailText.Text;
                DateTime orderDate = OrderDateTimePicker.Value;

                SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
                conn.Open();

                if (newOrder == true)
                {
                    string query0 =
                        "INSERT INTO Orders (OrderDate, CustName, CustPhone, CustEmail, OrderTotal) " +
                        "VALUES (datetime(@date), @name, @phone, @email, @total)";
                    SQLiteCommand cmd0 = new SQLiteCommand(query0, conn);
                    cmd0.Parameters.AddWithValue("@date", orderDate);
                    cmd0.Parameters.AddWithValue("@name", custName);
                    cmd0.Parameters.AddWithValue("@phone", custPhone);
                    cmd0.Parameters.AddWithValue("@email", custEmail);
                    cmd0.Parameters.AddWithValue("@total", orderTotal);

                    cmd0.ExecuteNonQuery();

                    string query2 =
                        "SELECT OrderId, CustName, CustPhone, CustEmail, OrderTotal " +
                        "FROM Orders " +
                        "WHERE CustName = @name AND CustPhone = @phone AND CustEmail = @email AND OrderTotal = @total";
                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@name", custName);
                    cmd2.Parameters.AddWithValue("@phone", custPhone);
                    cmd2.Parameters.AddWithValue("@email", custEmail);
                    cmd2.Parameters.AddWithValue("@total", orderTotal);

                    int savedOrderId = Convert.ToInt32(cmd2.ExecuteScalar());

                    SaveCart(savedOrderId);
                }
                else
                {
                    int orderId = Convert.ToInt32(OrderIdText.Text);

                    string query1 =
                        "UPDATE Orders " +
                        "SET OrderDate = datetime(@date), CustName = @name, CustPhone = @phone, CustEmail = @email, OrderTotal = @total " +
                        "WHERE OrderId = @ID";
                    SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("@ID", orderId);
                    cmd1.Parameters.AddWithValue("@date", orderDate);
                    cmd1.Parameters.AddWithValue("@name", custName);
                    cmd1.Parameters.AddWithValue("@phone", custPhone);
                    cmd1.Parameters.AddWithValue("@email", custEmail);
                    cmd1.Parameters.AddWithValue("@total", orderTotal);

                    cmd1.ExecuteNonQuery();

                    SaveCart(orderId);
                }
                conn.Close();
                this.Close();
            }
        }
    }
}
