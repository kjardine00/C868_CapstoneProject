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
    public partial class ProductsByDate : Form
    {
        public ProductsByDate()
        {
            InitializeComponent();
            LoadPicker();
            RunReport();
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

            ProductPicker.ValueMember = null;
            ProductPicker.DisplayMember = "ProdName";
            ProductPicker.DataSource = picker;

            conn.Close();
        }

        private void RunReport()
        {
            Product product = (Product)ProductPicker.SelectedItem;
            DataTable ProductsByDate = new DataTable();

            int ProdID = product.ProdID;
            DateTime start = StartDateTimePicker.Value;
            DateTime end = EndDateTimePicker.Value;

            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();

            string query0 =
                "SELECT Orders.OrderDate, OrderItems.ProdQty " +
                "FROM Orders " +
                "INNER JOIN OrderItems " +
                "ON Orders.OrderId = OrderItems.OrderId " +
                "WHERE OrderItems.ProductId = @PID AND Orders.OrderDate >= @start AND Orders.OrderDate <= @end;";

            SQLiteCommand cmd = new SQLiteCommand(query0, conn);
            cmd.Parameters.AddWithValue("@PID", ProdID);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);

            SQLiteDataAdapter prodAdapter = new SQLiteDataAdapter(cmd);
            prodAdapter.Fill(ProductsByDate);

            ReportDGV.DataSource = ProductsByDate;

            conn.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunReport();
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RunReport();
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RunReport();
        }
    }
}
