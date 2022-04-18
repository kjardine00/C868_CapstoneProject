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
    public partial class MoneyByDate : Form
    {
        public MoneyByDate()
        {
            InitializeComponent();
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
    }
}
