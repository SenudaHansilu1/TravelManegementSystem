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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                this.Hide();
                new Form5().ShowDialog();
            }
            else
            {
                MessageBox.Show("Users can't access ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
