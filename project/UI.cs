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
    public partial class UI : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public void showbook() //แสดงหนังสือ
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
            ShowAllBook.DataSource = dt;
        }
        private void searchBookName(string valuetofind) //ค้นหาชื่อหนังสือ
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string search = "SELECT * FROM booklist WHERE book_name LIKE '%" + textBox1.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ShowAllBook.DataSource = dt;
            conn.Close();
        }
        private void searchBookType(string valuetofind) //ค้นหาประเภทหนังสือ
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string search = "SELECT * FROM booklist WHERE book_type LIKE '%" + comboBox1.Text + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(search, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ShowAllBook.DataSource = dt;
            conn.Close();
        }
        int itemBuy = 0;
        private void Update_Data() //อัพประวัติการซื้อ , ตัด stock
        {
            MySqlConnection conn = databaseConnection();
            var time = DateTime.Now;
            string date = time.ToString("dd/MM/yyyy | HH:mm:ss");

            for (int i = 0; i < BookList.Rows.Count; i++)
            {
                conn.Open();
                string select = "SELECT * FROM booklist WHERE id='" + BookList.Rows[i].Cells[0].Value + "'";
                MySqlCommand cmd = new MySqlCommand(select, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox6.Text = (dr["book_item"].ToString());
                    conn.Close();

                    itemBuy = Convert.ToInt32(BookList.Rows[i].Cells[3].Value);
                    int newitem = Convert.ToInt32(textBox6.Text) - itemBuy;

                    conn.Open();
                    string edit = "UPDATE `booklist` SET `book_item`='" + newitem + "' WHERE id='" + BookList.Rows[i].Cells[0].Value + "'";
                    MySqlCommand cmd2 = new MySqlCommand(edit, conn);
                    cmd2.ExecuteNonQuery();

                    string buylist = "INSERT INTO `buylist`(`order_by`, `book_name`, `book_total`, `book_price`, `time`, `state`) VALUES ('" + Program.user + "','" + BookList.Rows[i].Cells[1].Value + "','" + BookList.Rows[i].Cells[3].Value + "','" + BookList.Rows[i].Cells[4].Value + "','" + date + "','รอการตรวจสอบการชำระเงิน')";
                    MySqlCommand cmd3 = new MySqlCommand(buylist, conn);
                    cmd3.ExecuteNonQuery();
                    
                    conn.Close();
                }
            }
        }
        public UI()
        {
            InitializeComponent();
            label1.Text = Program.user;
        }

        private void UI_Load(object sender, EventArgs e)
        {
            showbook();
        }
        private void ShowAllBook_CellClick(object sender, DataGridViewCellEventArgs e) //เอาข้อมูลในตารางมาใส่ใน textbox
        {
            ShowAllBook.CurrentRow.Selected = true;
            textBox4.Text = ShowAllBook.SelectedRows[0].Cells[1].Value.ToString();
            textBox5.Text = ShowAllBook.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = ShowAllBook.SelectedRows[0].Cells[3].Value.ToString();
            textBox8.Text = ShowAllBook.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e) //เพิ่มสินค้าลงตระกร้า
        {
            if (textBox3.Text == "" || Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox8.Text) || textBox3.Text == "0")
            {
                MessageBox.Show("ท่านหยิบสินค้าเกินจำนวนที่มีอยู่ในคลัง","ผิดพลาด");
            }
            else
            {
                int total = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox2.Text);
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(BookList);
                newrow.Cells[0].Value = ShowAllBook.SelectedRows[0].Cells[0].Value;
                newrow.Cells[1].Value = textBox4.Text;
                newrow.Cells[2].Value = textBox2.Text;
                newrow.Cells[3].Value = textBox3.Text;
                newrow.Cells[4].Value = total;
                BookList.Rows.Add(newrow);
                TotalPrice();
                textBox3.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBookType(comboBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchBookName(textBox1.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showbook();
        }

        private void btnClear_Click(object sender, EventArgs e) //เคลียร์สินค้า
        {
            BookList.Rows.Clear();
            TotalPrice();
        }

        private void btnBuy_Click(object sender, EventArgs e) //ปุ่มยืนยันการซื้อ
        {
            if (BookList.Rows.Count == 0)
            {
                MessageBox.Show("ยังไม่มีสินค้าในตระกร้า", "ผิดพลาด");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("ต้องการที่จะยืนยันการสั่งซื้อเลยหรือไม่", "ยืนยันการสั่งซื้อ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    qr qr = new qr();
                    qr.Show();
                    Update_Data();
                    TotalPrice();
                    showbook();
                    
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Bill", 285, 430);
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    BookList.Rows.Clear();
                    TotalPrice();

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) //ทำให้ช่องใส่สินค้าใส่ได้แค่ตัวเลข
        {
            char c = e.KeyChar;

            if (!char.IsDigit(c) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e) //ออกจากระบบ
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการจะออกจากระบบหรือไม่", "ออกจากระบบ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //ลบสินค้าออกจากตะกร้า
        {
            if(BookList.Rows.Count == 0)
            {
                MessageBox.Show("ยังไม่มีสินค้าในตระกร้า", "ผิดพลาด");
            }
            else
            {
                int row = BookList.CurrentCell.RowIndex;
                BookList.Rows.RemoveAt(row);
                TotalPrice();
            }
        }

        private void label12_Click(object sender, EventArgs e) //ดูประวัติการซื้อ
        {
            History hs = new History();
            hs.Show();
        }

        private void label13_Click(object sender, EventArgs e) //ดูข้อมูลตัวเอง
        {
            userEdit ue = new userEdit();
            ue.Show();
        }

        public void TotalPrice() //คำนวณเงินรวมในตะกร้า
        {
            int sum = 0;
            for (int i = 0; i < BookList.Rows.Count; i++)
            {
                sum = sum + int.Parse(BookList.Rows[i].Cells[4].Value.ToString());
            }
            label10.Text = sum.ToString();
            Program.total = label10.Text;
        }

        int qty, price, total, pos = 100;
        string name;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //ใบเสร็จ
        {
            var time = DateTime.Now;
            string date = time.ToString("dd/MM/yyyy | HH:mm:ss");

            e.Graphics.DrawString("***********************************************************", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(36));
            e.Graphics.DrawString("ใบเสร็จร้าน Read World", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(80, 10));
            e.Graphics.DrawString("***********************************************************", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(36, 20));
            e.Graphics.DrawString("วันที่ : " + date, new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(36, 30));
            e.Graphics.DrawString("บัญชีผู้ใช้ : " + Program.user , new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(36, 50));
            e.Graphics.DrawString("ชื่อหนังสือ", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(15, 75));
            e.Graphics.DrawString("จำนวน", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(145, 75));
            e.Graphics.DrawString("ราคา", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(225, 75));
            foreach (DataGridViewRow row in BookList.Rows)
            {
                name = "" + row.Cells[1].Value;
                qty = Convert.ToInt32(row.Cells[3].Value);
                price = Convert.ToInt32(row.Cells[4].Value);
                total = Convert.ToInt32(label10.Text);
                e.Graphics.DrawString("" + name, new Font("Browallia New", 8, FontStyle.Bold), Brushes.Black, new Point(13, pos));
                e.Graphics.DrawString("" + qty, new Font("Browallia New", 8, FontStyle.Bold), Brushes.Black, new Point(160, pos));
                e.Graphics.DrawString("" + price + " บาท", new Font("Browallia New", 8, FontStyle.Bold), Brushes.Black, new Point(230, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("***********************************************************", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(36, 340));
            e.Graphics.DrawString("ราคารวม : " + total + " บาท", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(100, 350));
            e.Graphics.DrawString("***********************************************************", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(36, 360));
            e.Graphics.DrawString("ขอบคุณที่อุดหนุนครับ / ค่ะ", new Font("Browallia New", 10, FontStyle.Bold), Brushes.Black, new Point(90, 380));
            pos = 100;
        }
    }
}
