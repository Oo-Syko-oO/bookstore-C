using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class qr : Form
    {
        public qr()
        {
            InitializeComponent();
            label6.Text = Program.total;
        }  
        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void qr_Load(object sender, EventArgs e)
        {
        }
    }
}
