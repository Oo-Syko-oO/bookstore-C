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
using System.IO;

namespace project
{
    public partial class manage : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        
        public manage()
        {
            InitializeComponent();
        }

        public void showbook()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM booklist";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dataShowbook.DataSource = dt;
        }

        private void manage_Load(object sender, EventArgs e)
        {
            showbook();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dataShowbook_CellClick(object sender, DataGridViewCellEventArgs e) //เอาข้อมูลในตารางมาแสดงใน textbox
        {
            dataShowbook.CurrentRow.Selected = true;
            textBox1.Text = dataShowbook.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataShowbook.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataShowbook.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataShowbook.SelectedRows[0].Cells[4].Value.ToString();

            Byte[] img = (Byte[])dataShowbook.SelectedRows[0].Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
        }
        private void dataShowbook_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataShowbook_Click(object sender, EventArgs e)
        {

        }

        private void addBook_Click(object sender, EventArgs e) //เพิ่มหนังสือลง database
        {
            MySqlConnection conn = databaseConnection();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("กรุณากรอกข้อมูลหนังสือให้ครบทุกช่องก่อนเพิ่มหนังสือ", "ผิดพลาด");
            }
            else
            {
                conn.Open();
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand command = new MySqlCommand("INSERT INTO `booklist`(`book_name`, `book_type`, `book_price`, `book_item`, `image`) VALUES (@name, @type, @price, @item, @img)", conn);

                command.Parameters.Add("@name", MySqlDbType.VarString).Value = textBox1.Text;
                command.Parameters.Add("@type", MySqlDbType.VarString).Value = comboBox1.Text;
                command.Parameters.Add("@price", MySqlDbType.Int64).Value = textBox2.Text;
                command.Parameters.Add("@item", MySqlDbType.Int64).Value = textBox3.Text;
                command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

                command.ExecuteNonQuery();

                MessageBox.Show("เพิ่มหนังสือเสร็จสิ้น", "สำเร็จ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                showbook();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) //กลับหน้า login
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void label13_Click(object sender, EventArgs e) //ปุ่มเคลียร์
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
        }
        private void editBook_Click(object sender, EventArgs e) //ปุ่มแก้ไขข้อมูล
        {
            MySqlConnection conn = databaseConnection();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("กรุณากรอกข้อมูลหนังสือให้ครบทุกช่องก่อนแก้ไขข้อมูล", "ผิดพลาด");
            }
            else
            {
                int selectedRow = dataShowbook.CurrentCell.RowIndex;
                int editID = Convert.ToInt32(dataShowbook.Rows[selectedRow].Cells["Column5"].Value);

                conn.Open();
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                MySqlCommand command = new MySqlCommand("UPDATE `booklist` SET `book_name`=@name,`book_type`=@type,`book_price`=@price,`book_item`=@item,`image`=@img WHERE id='" + editID + "'", conn);

                command.Parameters.Add("@name", MySqlDbType.VarString).Value = textBox1.Text;
                command.Parameters.Add("@type", MySqlDbType.VarString).Value = comboBox1.Text;
                command.Parameters.Add("@price", MySqlDbType.Int64).Value = textBox2.Text;
                command.Parameters.Add("@item", MySqlDbType.Int64).Value = textBox3.Text;
                command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

                command.ExecuteNonQuery();

                MessageBox.Show("แก้ไขหนังสือสำเร็จ", "สำเร็จ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                showbook();
                conn.Close();
            }
        }
        private void deleteBook_Click(object sender, EventArgs e) //ปุ่มลบหนังสือ
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการจะลบข้อมูลหนังสือหรือไม่", "ยืนยันการลบซื้อ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int selectedRow = dataShowbook.CurrentCell.RowIndex;
                int deleteID = Convert.ToInt32(dataShowbook.Rows[selectedRow].Cells["Column5"].Value);

                MySqlConnection conn = databaseConnection();
                conn.Open();

                string delete = "DELETE FROM booklist WHERE id = '" + deleteID + "'";
                MySqlCommand cmd = new MySqlCommand(delete, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("ลบหนังสือสำเร็จ", "สำเร็จ");
                showbook();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Allhistory ahs = new Allhistory();
            ahs.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            AllUser au = new AllUser();
            au.Show();
        }

        private void button2_Click_1(object sender, EventArgs e) //ปุ่มอัพรูป
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.jpeg;*.png;) | *.jpg;*.jpeg;*.png;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
