namespace project
{
    partial class Allhistory
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
            this.historydata = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historydata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // historydata
            // 
            this.historydata.AllowUserToAddRows = false;
            this.historydata.AllowUserToDeleteRows = false;
            this.historydata.AllowUserToOrderColumns = true;
            this.historydata.BackgroundColor = System.Drawing.Color.LightBlue;
            this.historydata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historydata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historydata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column7});
            this.historydata.Location = new System.Drawing.Point(91, 95);
            this.historydata.Name = "historydata";
            this.historydata.ReadOnly = true;
            this.historydata.Size = new System.Drawing.Size(863, 365);
            this.historydata.TabIndex = 44;
            this.historydata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historydata_CellClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id";
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "book_name";
            this.Column1.HeaderText = "หนังสือ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 280;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "order_by";
            this.Column4.HeaderText = "จากบัญชีผู้ใช้";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "book_total";
            this.Column2.HeaderText = "จำนวน";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "book_price";
            this.Column3.HeaderText = "ราคา";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "time";
            this.Column5.HeaderText = "สั่งซื้อวันที่";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "state";
            this.Column7.HeaderText = "สถานะการสั่งซื้อ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(127, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 39);
            this.label12.TabIndex = 45;
            this.label12.Text = "ประวัติการสั่งซื้อทั้งหมด";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(973, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 470);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(897, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 391);
            this.panel2.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(12, -14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 390);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(973, -14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 174);
            this.panel3.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(12, 458);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(57, 201);
            this.panel5.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(91, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 31);
            this.textBox1.TabIndex = 52;
            this.textBox1.Tag = "";
            this.textBox1.Text = "กรอกชื่อ User";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::project.Properties.Resources.loupe;
            this.pictureBox4.Location = new System.Drawing.Point(91, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 32);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("maaja", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.Location = new System.Drawing.Point(703, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 33);
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.Text = "รีเฟรช";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ยืนยันการชำระแล้ว",
            "จัดส่งสำเร็จ"});
            this.comboBox1.Location = new System.Drawing.Point(91, 484);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 32);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.Text = "เลือกสถานะ";
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.FlatAppearance.BorderSize = 2;
            this.btnUpdateState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateState.Font = new System.Drawing.Font("maaja", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateState.ForeColor = System.Drawing.Color.Green;
            this.btnUpdateState.Location = new System.Drawing.Point(343, 484);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(119, 43);
            this.btnUpdateState.TabIndex = 57;
            this.btnUpdateState.Text = "อัพเดตสถานะ";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            this.btnUpdateState.Click += new System.EventHandler(this.btnUpdateState_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleName = "";
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "รอการตรวจสอบการชำระเงิน",
            "ยืนยันการชำระแล้ว",
            "จัดส่งสำเร็จ"});
            this.comboBox2.Location = new System.Drawing.Point(462, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 32);
            this.comboBox2.TabIndex = 58;
            this.comboBox2.Text = "เลือกสถานะ";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(495, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 59;
            this.label1.Text = "ยอดขายทั้งหมด";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(696, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 39);
            this.label2.TabIndex = 60;
            this.label2.Text = "-";
            // 
            // Allhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1042, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnUpdateState);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.historydata);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Allhistory";
            this.Text = "All History";
            this.Load += new System.EventHandler(this.Allhistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historydata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historydata;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnUpdateState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}