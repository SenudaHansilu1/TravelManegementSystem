using System;
using System.Windows.Forms;

namespace Travel_Management_System
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm12 = new Form5();
            frm12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
