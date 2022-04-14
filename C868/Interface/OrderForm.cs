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

        public OrderForm(bool isNew, int orderId)
        {
            newOrder = isNew;
            oId = orderId;

            InitializeComponent();
            LoadForm(orderId);
            LoadCart(orderId);
            LoadPicker();
        }

        private void LoadForm(int ordID)
        {
            if (newOrder == false)
            {
                Order loadOrder = null;

                SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
                conn.Open();

                string query0 = "SELECT OrderId, CustName, CustPhone, CustEmail, OrderTotal FROM Order WHERE OrderId = @Id";
                SQLiteCommand ordCmd = new SQLiteCommand(query0, conn);
                ordCmd.Parameters.AddWithValue("@Id", ordID);

                using (SQLiteDataReader reader = ordCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        loadOrder = new Order(
                            Convert.ToInt32(reader["OrderId"]),
                            reader["CustName"].ToString(),
                            reader["CustPhone"].ToString(),
                            reader["CustEmail"].ToString(),
                            Convert.ToDecimal(reader["OrderTotal"])
                            );

                        OrderIdText.Text = loadOrder.OrderId.ToString();
                        CustNameText.Text = loadOrder.CustName.ToString();
                        CustPhoneText.Text = loadOrder.CustPhone.ToString();
                        CustEmailText.Text = loadOrder.CustEmail.ToString();
                    }
                    reader.Close();
                }
                conn.Close();


                DeleteBtn.Visible = true;
            }
            else
            {
                DeleteBtn.Visible = false;
            }
        }

        private void LoadCart(int ordId)
        {
            if (newOrder == false)
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
                conn.Open();

                string query1 = "SELECT OrderItems.EntryId, Product.ProdID, Product.ProdName, Product.Price, OrderItems.ProdQty" +
                    "FROM OrderItems" +
                    "INNERJOIN Product " +
                    "ON OrderItems.ProductId = Product" +
                    "WHERE OrderItems.OrderId = @Id";
                SQLiteCommand cartCmd = new SQLiteCommand(query1, conn);
                cartCmd.Parameters.AddWithValue("@Id", ordId);

                DataTable cartDataTable = new DataTable();

                SQLiteDataAdapter prodAdapter = new SQLiteDataAdapter(cartCmd);
                prodAdapter.Fill(cartDataTable);

                ProductCartDGV.DataSource = cartDataTable;

                conn.Close();
            }
        }

        private void LoadPicker()
        {
            BindingList<Product> picker = new BindingList<Product>();

            Product loadProd = null;

            SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
            conn.Open();

            string query1 = "SELECT ProdId, ProdName, ProdPrice, ProdSKU FROM Product";
            SQLiteCommand prodCmd = new SQLiteCommand(query1, conn);

            using (SQLiteDataReader reader = prodCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    loadProd = new Product(
                        Convert.ToInt32(reader["ProdId"]),
                        reader["ProdName"].ToString(),
                        reader["ProdSKU"].ToString(),
                        Convert.ToDecimal(reader["ProdPrice"])
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
            List<OrderItems> itemsList = new List<OrderItems>();
            OrderItems oItem = null;

            Product prod = (Product)ProdPicker.SelectedItem;
            int prodId = prod.ProdID;

            int prodQty = 0;

            SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
            conn.Open();

            string query1 = "SELECT EntryId, OrderId, ProductId, ProdQty FROM OrderItems WHERE OrderId = @Id";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            cmd.Parameters.AddWithValue("@Id", oId);

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    oItem = new OrderItems(
                        Convert.ToInt32(reader["ProdId"]),
                        Convert.ToInt32(reader["ProdId"]),
                        Convert.ToInt32(reader["ProdId"]),
                        Convert.ToInt32(reader["ProdId"])
                        );

                    itemsList.Add(oItem);
                }
                reader.Close();
            }

            foreach (OrderItems item in itemsList)
            {
                if (item.ProductId == prodId)
                {
                    prodQty++;
                }
            }

            if (prodQty > 0)
            {
                string query2 = "UPDATE OrderItems SET ProdQty = @Qty WHERE ProdId = @pId";
                SQLiteCommand cmd2 = new SQLiteCommand(query1, conn);
                cmd2.Parameters.AddWithValue("@Qty", prodQty);
                cmd2.Parameters.AddWithValue("@pId", prodId);
            }
            else //Stopped here
            {
                string query3 = "INSERT OrderItems ProdQty = @Qty WHERE ProdId = @pId";
                SQLiteCommand cmd3 = new SQLiteCommand(query1, conn);
                cmd3.Parameters.AddWithValue("@Qty", prodQty);
                cmd3.Parameters.AddWithValue("@pId", prodId);
            }

            LoadCart(oId);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
