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
        }

        private void LoadPicker()
        {
            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();
        }

        private void RunReport()
        {
            SQLiteConnection conn = new SQLiteConnection(Program.LoadConnectionString());
            conn.Open();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
