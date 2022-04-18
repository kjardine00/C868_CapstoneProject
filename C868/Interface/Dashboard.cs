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
        private DataTable inventoryDataTable = new DataTable();
        private DataTable ordersDataTable = new DataTable();

        public Dashboard()
        {
            InitializeComponent();
            DGVrefresh();

            this.InventoryDGV.Columns[0].Visible = false;
            this.OrdersDGV.Columns[0].Visible = false;
        }

        private void DGVrefresh()
        {
            inventoryDataTable.Clear();
            ordersDataTable.Clear();

            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();

            string query1 = "SELECT * FROM Product";
            SQLiteCommand inventoryCmd = new SQLiteCommand(query1, conn);

            SQLiteDataAdapter prodAdapter = new SQLiteDataAdapter(inventoryCmd);
            prodAdapter.Fill(inventoryDataTable);

            InventoryDGV.DataSource = inventoryDataTable;

            string orderQuery = "SELECT * FROM Orders";
            SQLiteCommand ordersCmd = new SQLiteCommand(orderQuery, conn);

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

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            (OrdersDGV.DataSource as DataTable).DefaultView.RowFilter = string.Format("CustName like '{0}%'", SearchCustText.Text);
            OrdersDGV.Refresh();
        }

        private void SearchProductText_TextChanged(object sender, EventArgs e)
        {
            (InventoryDGV.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProdName like '{0}%' OR ProdSKU like '{0}%'", SearchProductText.Text);
            InventoryDGV.Refresh();
        }

        private void AddInventoryBtn_Click(object sender, EventArgs e)
        {
            new AdjustInventory().ShowDialog();
            DGVrefresh();
        }

        private void OrdersByMonth_Click(object sender, EventArgs e)
        {
            new OrderByDate().Show();
        }

        private void RevenueByMonth_Click(object sender, EventArgs e)
        {
            new MoneyByDate().Show();
        }

        private void ProductsSoldByDate_Click(object sender, EventArgs e)
        {
            new ProductsByDate().Show();
        }
    }
}
