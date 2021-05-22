using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = txtuname.Text;
            string pass = txtpass.Text;

            if(uname.Equals("Admin") && pass.Equals("1234"))
            {
                MainForm m = new MainForm();
                this.Hide();
                m.Show();
            }

            else
            {
                MessageBox.Show("Invalid Login");
                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtuname.Clear();
            txtpass.Clear();

            txtuname.Focus();

        }
    }
}
