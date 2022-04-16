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
    public partial class ProductForm : Form
    {
        bool newProd;
        public ProductForm(bool isNew, int prodId)
        {
            newProd = isNew;
            InitializeComponent();
            LoadForm(prodId);
        }

        private void LoadForm(int prodId)
        {
            if (newProd == false)
            {
                Product loadProd = null;

                SQLiteConnection conn = new SQLiteConnection(Program.connectionString);
                conn.Open();

                string query1 = "SELECT ProdId, ProdName, ProdPrice, ProdSKU, Quantity FROM Product WHERE ProdId = @ID";
                SQLiteCommand prodCmd = new SQLiteCommand(query1, conn);
                prodCmd.Parameters.AddWithValue("@ID", prodId);

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

                        ProdIdText.Text = loadProd.ProdID.ToString();
                        ProdNameText.Text = loadProd.ProdName;
                        ProdPriceText.Text = loadProd.ProdPrice.ToString();
                        ProdSKUText.Text = loadProd.ProdSKU;
                        QtyText.Text = loadProd.Quantity.ToString();
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int prodId = Convert.ToInt32(ProdIdText.Text);

            SQLiteConnection conn = new SQLiteConnection(Program.connectionString);
            conn.Open();

            string query1 = "DELETE FROM Product WHERE ProdId = @ID";
            SQLiteCommand prodCmd = new SQLiteCommand(query1, conn);
            prodCmd.Parameters.AddWithValue("@ID", prodId);

            prodCmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string prodName;
            decimal prodPrice;
            string prodSKU;
            int qty;

            prodName = ProdNameText.Text;
            prodSKU = ProdSKUText.Text;

            try
            {
                prodPrice = Convert.ToDecimal(ProdPriceText.Text);
            }
            catch
            {
                MessageBox.Show("Product Price must be a numeric value.", "Warning!");
                return;
            }

            try
            {
                qty = Convert.ToInt32(QtyText.Text);
            }
            catch
            {
                MessageBox.Show("Product Quantity must be a numeric value.", "Warning!");
                return;
            }

            SQLiteConnection conn = new SQLiteConnection(Program.connectionString);
            conn.Open();

            if (newProd == true)
            {
                string query0 = "INSERT INTO Product (ProdName, ProdPrice, ProdSKU, Quantity) VALUES (@name, @price, @sku, @qty)";
                SQLiteCommand prodCmd = new SQLiteCommand(query0, conn);
                prodCmd.Parameters.AddWithValue("@name", prodName);
                prodCmd.Parameters.AddWithValue("@price", prodPrice);
                prodCmd.Parameters.AddWithValue("@sku", prodSKU);
                prodCmd.Parameters.AddWithValue("@qty", qty);

                prodCmd.ExecuteNonQuery();
            }
            else
            {
                int prodId = Convert.ToInt32(ProdIdText.Text);

                string query1 = "UPDATE Product SET ProdName = @name, ProdSKU = @sku, ProdPrice = @price, Quantity = @qty WHERE ProdId = @ID";
                SQLiteCommand prodCmd = new SQLiteCommand(query1, conn);
                prodCmd.Parameters.AddWithValue("@name", prodName);
                prodCmd.Parameters.AddWithValue("@price", prodPrice);
                prodCmd.Parameters.AddWithValue("@sku", prodSKU);
                prodCmd.Parameters.AddWithValue("@qty", qty);

                prodCmd.ExecuteNonQuery();
                
            }
            conn.Close();
            this.Close();
        }
    }
}
