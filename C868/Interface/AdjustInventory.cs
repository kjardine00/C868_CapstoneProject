using C868.Models;
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

namespace C868
{
    public partial class AdjustInventory : Form
    {
        public AdjustInventory()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            BindingList<Product> picker = new BindingList<Product>();

            Product loadProd = null;

            SQLiteConnection conn = new SQLiteConnection(Program.connectionString);
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

            ProductComboBox.ValueMember = null;
            ProductComboBox.DisplayMember = "ProdName";
            ProductComboBox.DataSource = picker;

            conn.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int qtyToAdd = Convert.ToInt32(AmountNumeric.Value);

            Product prod = (Product)ProductComboBox.SelectedItem;

            SQLiteConnection conn = new SQLiteConnection(Program.connectionString);
            conn.Open();

            string query0 = "UPDATE Product SET Quantity = @qty WHERE ProdId = @pID";
            SQLiteCommand cmd0 = new SQLiteCommand(query0, conn);
            cmd0.Parameters.AddWithValue("@pID", prod.ProdID);
            cmd0.Parameters.AddWithValue("@qty", qtyToAdd);

            cmd0.ExecuteNonQuery();

            conn.Close();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
