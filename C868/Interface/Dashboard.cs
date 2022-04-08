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

namespace C868
{
    public partial class Dashboard : Form
    {
        BindingSource orderBindingSource = new BindingSource();
        BindingSource inventoryBindingSource = new BindingSource();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

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

        }

        private void UpdateProdBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
