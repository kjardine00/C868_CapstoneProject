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
    public partial class OrderByDate : Form
    {
        public OrderByDate()
        {
            InitializeComponent();
            RunReport();
        }

        private void RunReport()
        {
            List<Order> orderList = new List<Order>();

            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();

            string query0 = "SELECT OrderId, date(OrderDate), CustName, CustPhone, CustEmail, OrderTotal FROM Orders";
            SQLiteCommand cmd = new SQLiteCommand(query0, conn);

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["OrderId"]);
                    DateTime date = Convert.ToDateTime(reader["date(OrderDate)"]);
                    string name = reader["CustName"].ToString();
                    string phone = reader["CustPhone"].ToString();
                    string email = reader["CustEmail"].ToString();
                    decimal total = Convert.ToDecimal(reader["OrderTotal"]);

                    orderList.Add(new Order(id, date, name, phone, email, total));
                }
            }

            var ordersByMonth = orderList.GroupBy(x => new { Month = x.OrderDate.Month, Year = x.OrderDate.Year }).ToDictionary(g => g.Key, g => g.Count());

            BindingSource bindingSource = new BindingSource();
            ReportDGV.DataSource = bindingSource;
            bindingSource.DataSource = ordersByMonth;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
