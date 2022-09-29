namespace project
{
    partial class manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataShowbook = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.addBook = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataShowbook
            // 
            this.dataShowbook.AllowUserToAddRows = false;
            this.dataShowbook.AllowUserToDeleteRows = false;
            this.dataShowbook.AllowUserToOrderColumns = true;
            this.dataShowbook.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataShowbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataShowbook.Location = new System.Drawing.Point(154, 245);
            this.dataShowbook.Name = "dataShowbook";
            this.dataShowbook.ReadOnly = true;
            this.dataShowbook.RowTemplate.Height = 100;
            this.dataShowbook.Size = new System.Drawing.Size(695, 432);
            this.dataShowbook.TabIndex = 1;
            this.dataShowbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataShowbook_CellClick);
            this.dataShowbook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataShowbook_CellContentClick_1);
            this.dataShowbook.Click += new System.EventHandler(this.dataShowbook_Click);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "book_name";
            this.Column1.HeaderText = "ชื่อหนังสือ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "book_type";
            this.Column2.HeaderText = "ประเภท";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "book_price";
            this.Column3.HeaderText = "ราคา";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "book_item";
            this.Column4.HeaderText = "จำนวน (เล่ม)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "image";
            this.Column6.HeaderText = "ภาพ";
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 103;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "หนังสือเรียน",
            "หนังสือการ์ตูน",
            "หนังสือสารคดี",
            "หนังสือนิยาย"});
            this.comboBox1.Location = new System.Drawing.Point(452, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 32);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "เลือกประเภทหนังสือ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(448, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "ประเภทหนังสือ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(158, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "ชื่อหนังสือ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(162, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(673, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "ราคาหนังสือ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox2.Location = new System.Drawing.Point(677, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 29);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(894, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "จำนวน";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox3.Location = new System.Drawing.Point(898, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 29);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("maaja", 18.25F);
            this.button1.Location = new System.Drawing.Point(1282, 703);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(1098, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 39);
            this.label13.TabIndex = 16;
            this.label13.Text = "เคลียร์ข้อมูล";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // addBook
            // 
            this.addBook.AutoSize = true;
            this.addBook.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.addBook.ForeColor = System.Drawing.Color.LimeGreen;
            this.addBook.Location = new System.Drawing.Point(147, 162);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(113, 39);
            this.addBook.TabIndex = 17;
            this.addBook.Text = "เพิ่มหนังสือ";
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(363, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "แก้ ไขข้อมูลหนังสือ";
            this.label7.Click += new System.EventHandler(this.editBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(637, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "ลบหนังสือ";
            this.label8.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(817, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "ข้อมูลการสั่งซื้อทั้งหมด";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Peru;
            this.label9.Location = new System.Drawing.Point(1074, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 39);
            this.label9.TabIndex = 21;
            this.label9.Text = "ดู User ทั้งหมด";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(129, 682);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 125);
            this.panel3.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(66, 703);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 144);
            this.panel2.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(3, 724);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 177);
            this.panel1.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(1244, -9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(57, 145);
            this.panel5.TabIndex = 61;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(35, -9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 170);
            this.panel6.TabIndex = 60;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(1307, -39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 135);
            this.panel4.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(978, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("maaja", 18.25F);
            this.button2.Location = new System.Drawing.Point(1064, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 64;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.Location = new System.Drawing.Point(931, 647);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(57, 160);
            this.panel7.TabIndex = 60;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Location = new System.Drawing.Point(994, 724);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(57, 123);
            this.panel8.TabIndex = 59;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel9.Location = new System.Drawing.Point(1057, 682);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(57, 219);
            this.panel9.TabIndex = 58;
            // 
            // manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1385, 749);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataShowbook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataShowbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataShowbook;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label addBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}