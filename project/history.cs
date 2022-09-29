using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class History : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public History()
        {
            InitializeComponent();
        }
        public void showhistory()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string search = "SELECT book_name, book_total, book_price, time, state FROM buylist WHERE order_by LIKE '%" + Program.user + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            historydata.DataSource = dt;
            conn.Close();
        }
        private void searchTime(string valuetofind)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string search = "SELECT * FROM buylist WHERE time LIKE '%" + dateTimePicker1.Text + "%' AND order_by LIKE '%" + Program.user + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            historydata.DataSource = dt;
            conn.Close();
        }
        private void history_Load(object sender, EventArgs e)
        {
            showhistory();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            qrAgain qra = new qrAgain();
            qra.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchTime(dateTimePicker1.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showhistory();
        }
    }
}
