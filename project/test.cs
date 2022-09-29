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
    public partial class test : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public test()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        int item = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            string select = "SELECT * FROM booklist WHERE id = "+ int.Parse(textBox2.Text);
            MySqlCommand cmd = new MySqlCommand(select, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                textBox1.Text = (dr["book_item"].ToString());
                item = Convert.ToInt32(textBox1.Text) - 5;
                textBox3.Text = item.ToString();
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            int value = number.Next(10000, 99999);
            label1.Text = value.ToString();
        }
    }
}
