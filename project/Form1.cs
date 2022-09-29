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
    public partial class Form1 : Form
    {

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ปุ่ม login
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            string login = "SELECT * FROM user WHERE userID='" + textBox1.Text + "'AND pass='" + textBox2.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(login, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Program.user = textBox1.Text;
                UI ui = new UI();
                ui.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("บัญชีผู้ใช้หรือรหัสผ่านไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง","ผิดพลาด");
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //เคลียร์
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e) //ปุ่มสมัคร
        {
            register regis = new register();
            regis.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e) //ปุ่ม admin
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }
    }
}
