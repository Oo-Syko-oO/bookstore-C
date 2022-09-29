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
    public partial class register : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e) //ปุ่มสมัคร
        {
            MySqlConnection conn = databaseConnection();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง","ผิดพลาด");
            }
            else
            {
                if (textBox2.Text == textBox3.Text && textBox4.Text.Length == 10)
                {
                    conn.Open();
                    string user = "SELECT * FROM user WHERE userID='" + textBox1.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(user, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("ชื่อบัญชีนี้ถูกใช้งานแล้ว กรุณาเปลี่ยนชื่อบัญชีผู้ใช้ใหม่", "ผิดพลาด");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        
                        conn.Open();
                        string regis = "INSERT INTO user (userID, pass, username, phon, address) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "')";
                        MySqlCommand cmd2 = new MySqlCommand(regis, conn);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("ลงทะเบียนเสร็จสิ้น", "สำเร็จ");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        richTextBox1.Clear();
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("มีข้อมูลบางช่องไม่ถูกต้อง กรุณาตรวจสอบอีกครั้ง","ผิดพลาด");
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
