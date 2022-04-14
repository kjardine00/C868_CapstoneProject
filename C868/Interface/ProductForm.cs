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

                SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
                conn.Open();

                string query1 = "SELECT ProdId, ProdName, ProdPrice, ProdSKU FROM Product WHERE ProdId = @ID";
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
                            Convert.ToDecimal(reader["ProdPrice"])
                            );

                        ProdIdText.Text = loadProd.ProdID.ToString();
                        ProdNameText.Text = loadProd.ProdName;
                        ProdPriceText.Text = loadProd.ProdPrice.ToString();
                        ProdSKUText.Text = loadProd.ProdSKU;
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

            SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
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

            try
            {
                prodName = ProdNameText.Text;
                prodPrice = Convert.ToDecimal(ProdPriceText.Text);
                prodSKU = ProdSKUText.Text;
            }
            catch
            {
                MessageBox.Show("Product Price must be a numeric value.", "Error");
                return;
            }

            if (newProd == true)
            {
                SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
                conn.Open();

                string query0 = "INSERT INTO Product (ProdName, ProdPrice, ProdSKU) VALUES (@name, @price, @sku)";
                SQLiteCommand prodCmd = new SQLiteCommand(query0, conn);
                prodCmd.Parameters.AddWithValue("@name", prodName);
                prodCmd.Parameters.AddWithValue("@price", prodPrice);
                prodCmd.Parameters.AddWithValue("@sku", prodSKU);
                

                prodCmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            else
            {
                int prodId = Convert.ToInt32(ProdIdText.Text);

                SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
                conn.Open();

                string query1 = "UPDATE Product SET ProdName = @name, ProdSKU = @sku, ProdPrice = @price WHERE ProdId = @ID";
                SQLiteCommand prodCmd = new SQLiteCommand(query1, conn);
                prodCmd.Parameters.AddWithValue("@name", prodName);
                prodCmd.Parameters.AddWithValue("@price", prodPrice);
                prodCmd.Parameters.AddWithValue("@sku", prodSKU);

                prodCmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }
    }
}
