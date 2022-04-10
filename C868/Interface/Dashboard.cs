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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\VS Projects\C868\db.db");
            conn.Open();

            string query1 = "SELECT * FROM Product";
            SQLiteCommand inventoryCmd = new SQLiteCommand(query1, conn);

            DataTable inventoryDataTable = new DataTable();

            SQLiteDataAdapter prodAdapter = new SQLiteDataAdapter(inventoryCmd);
            prodAdapter.Fill(inventoryDataTable);

            InventoryDGV.DataSource = inventoryDataTable;

            string orderQuery = "SELECT * FROM Product";
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
            Order NewOrder = new Order
            {

            };
            new OrderForm(isNewOrder, NewOrder).ShowDialog();
        }

        private void UpdateOrderBtn_Click(object sender, EventArgs e)
        {
            bool isNewOrder = true;
            Order UpdateOrder = (Order)OrdersDGV.CurrentRow.DataBoundItem;
            new OrderForm(isNewOrder, UpdateOrder).ShowDialog();
        }

        private void NewProdBtn_Click(object sender, EventArgs e)
        {
            bool isNewProd = true;
            Product NewProduct = new Product
            {

            };
            new ProductForm(isNewProd, NewProduct).ShowDialog();
        }

        private void UpdateProdBtn_Click(object sender, EventArgs e)
        {
            bool isNewProd = false;
            Product UpdateProduct = (Product)InventoryDGV.CurrentRow.DataBoundItem;
            new ProductForm(isNewProd, UpdateProduct);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
