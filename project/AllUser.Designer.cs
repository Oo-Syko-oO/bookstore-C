namespace project
{
    partial class AllUser
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
            this.userdata = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // userdata
            // 
            this.userdata.AllowUserToAddRows = false;
            this.userdata.AllowUserToDeleteRows = false;
            this.userdata.AllowUserToOrderColumns = true;
            this.userdata.BackgroundColor = System.Drawing.Color.LightBlue;
            this.userdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.userdata.Location = new System.Drawing.Point(86, 97);
            this.userdata.Name = "userdata";
            this.userdata.ReadOnly = true;
            this.userdata.Size = new System.Drawing.Size(863, 365);
            this.userdata.TabIndex = 49;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "userID";
            this.Column1.HeaderText = "ชื่อบัญชี";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "username";
            this.Column4.HeaderText = "ชื่อ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "phon";
            this.Column2.HeaderText = " เบอร์โทร";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "address";
            this.Column3.HeaderText = "ที่อยู่";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("maaja", 25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(809, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 39);
            this.label12.TabIndex = 50;
            this.label12.Text = "User ทั้งหมด";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::project.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(758, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Location = new System.Drawing.Point(12, 338);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(57, 304);
            this.panel5.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(12, -17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 177);
            this.panel4.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(531, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 160);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(594, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 135);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(657, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 125);
            this.panel3.TabIndex = 56;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(973, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 391);
            this.panel6.TabIndex = 57;
            // 
            // AllUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1042, 577);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AllUser";
            this.Text = "All User";
            this.Load += new System.EventHandler(this.AllUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView userdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
    }
}