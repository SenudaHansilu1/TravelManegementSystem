using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm9 = new Form6();
            frm9.TopLevel = false;
            panel2.Controls.Add(frm9);
            frm9.BringToFront();
            frm9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm10 = new Form7();
            frm10.TopLevel = false;
            panel2.Controls.Add(frm10);
            frm10.BringToFront();
            frm10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 frm11 = new Form8();
            frm11.TopLevel = false;
            panel2.Controls.Add(frm11);
            frm11.BringToFront();
            frm11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm15 = new Form1();
            frm15.Show();
        }
    }
}
