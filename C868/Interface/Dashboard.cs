using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C868.Models;
using System.Data.SQLite;


namespace C868
{
    public partial class Dashboard : Form
    {
        BindingSource orderBindingSource = new BindingSource();
        BindingSource inventoryBindingSource = new BindingSource();

        public Dashboard(string dbPath)
        {
            InitializeComponent();
            DGVrefresh();
        }

        private void DGVrefresh()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
            conn.Open();

            string query1 = "SELECT * FROM Product";
            SQLiteCommand inventoryCmd = new SQLiteCommand(query1, conn);

            DataTable inventoryDataTable = new DataTable();

            SQLiteDataAdapter prodAdapter = new SQLiteDataAdapter(inventoryCmd);
            prodAdapter.Fill(inventoryDataTable);

            InventoryDGV.DataSource = inventoryDataTable;

            string orderQuery = "SELECT * FROM Orders";
            SQLiteCommand ordersCmd = new SQLiteCommand(orderQuery, conn);

            DataTable ordersDataTable = new DataTable();

            SQLiteDataAdapter ordersAdapter = new SQLiteDataAdapter(ordersCmd);
            ordersAdapter.Fill(ordersDataTable);

            OrdersDGV.DataSource = ordersDataTable;

            conn.Close();
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            bool isNewOrder = true;
            int orderId = 1;
            new OrderForm(isNewOrder, orderId).ShowDialog();

            DGVrefresh();
        }

        private void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            bool isNewOrder = false;

            if (OrdersDGV.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(OrdersDGV.SelectedRows[0].Cells[0].Value);

                new OrderForm(isNewOrder, orderId).ShowDialog();

                DGVrefresh();
            }
            else
            {
                MessageBox.Show("Please select an Order you would like to update.");
            }
        }

        private void NewProdBtn_Click(object sender, EventArgs e)
        {
            bool isNewProd = true;
            int prodId = 0;
            new ProductForm(isNewProd, prodId).ShowDialog();

            DGVrefresh();
        }

        private void UpdateProdBtn_Click(object sender, EventArgs e)
        {
            bool isNewProd = false;

            if (InventoryDGV.SelectedRows.Count > 0)
            {
                int prodId = Convert.ToInt32(InventoryDGV.SelectedRows[0].Cells[0].Value);

                new ProductForm(isNewProd, prodId).ShowDialog();

                DGVrefresh();
            }
            else
            {
                MessageBox.Show("Please select a Product you would like to update.");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
