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
    public partial class Allhistory : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Allhistory()
        {
            InitializeComponent();
        }
        public void showAllhistory()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM buylist";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            historydata.DataSource = dt;
        }
        private void Allhistory_Load(object sender, EventArgs e)
        {
            showAllhistory();
            TotalPrice();
        }
        private void searchUser(string valuetofind)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string search = "SELECT * FROM buylist WHERE order_by LIKE '%" + textBox1.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            historydata.DataSource = dt;
            conn.Close();
        }

        private void searchTime(string valuetofind) //ค้นหาตามวันที่ซื้อ
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string search = "SELECT * FROM buylist WHERE time LIKE '%" + dateTimePicker1.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            historydata.DataSource = dt;
            conn.Close();
        }
        private void searchState(string valuetofind) //ค้นหาตามสถาณะ
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string search = "SELECT * FROM buylist WHERE state LIKE '%" + comboBox2.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            historydata.DataSource = dt;
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchUser(textBox1.Text);
            TotalPrice();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchTime(dateTimePicker1.Text);
            TotalPrice();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showAllhistory();
            TotalPrice();
        }

        private void btnUpdateState_Click(object sender, EventArgs e)  //อัพเดทสถาณะสินค้า
        {
            int selectedRow = historydata.CurrentCell.RowIndex;
            int UpdateID = Convert.ToInt32(historydata.Rows[selectedRow].Cells[0].Value);

            MySqlConnection conn = databaseConnection();
            conn.Open();

            string update = "UPDATE `buylist` SET `state`='" + comboBox1.Text + "' WHERE id='" + UpdateID + "'";
            MySqlCommand cmd = new MySqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            
            conn.Close();
            MessageBox.Show("อัพเดตข้อมูลสำเร็จ", "สำเร็จ");
            showAllhistory();
        }

        private void historydata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            historydata.CurrentRow.Selected = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchState(comboBox2.Text);
            TotalPrice();
        }
        public void TotalPrice() //คำนวณเงินรวมในตาราง
        {
            int sum = 0;
            for (int i = 0; i < historydata.Rows.Count; i++)
            {
                sum = sum + int.Parse(historydata.Rows[i].Cells[4].Value.ToString());
            }
            label2.Text = sum.ToString();
        }
    }
}
