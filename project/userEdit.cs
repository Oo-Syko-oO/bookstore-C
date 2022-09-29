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
    public partial class userEdit : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public userEdit()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "" || textBox1.Text.Length != 10 || richTextBox1.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลลงในช่องให้ครบและถูกต้อง","ผิดพลาด");
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                string edit = "UPDATE `user` SET `address`='" + richTextBox1.Text + "',`phon`='" + textBox1.Text + "',`username`='" + textBox2.Text + "' WHERE userID='" + Program.user + "'";
                MySqlCommand cmd = new MySqlCommand(edit, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ","สำเร็จ");
            }
        }

        private void userEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            string select = "SELECT * FROM user WHERE userID = '" + Program.user + "'";
            MySqlCommand cmd = new MySqlCommand(select, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                richTextBox1.Text = (dr["address"].ToString());
                textBox1.Text = (dr["phon"].ToString());
                textBox2.Text = (dr["username"].ToString());
            }
            conn.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
