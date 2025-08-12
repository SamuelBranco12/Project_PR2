using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PR2
{
    public partial class Login_screen : Form
    {
        public Login_screen()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_clock(object sender, EventArgs e)
        {
            textBox2.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Storebtn_Click(object sender, EventArgs e)
        {
            Buy_or_RegisterInstrument product = new Buy_or_RegisterInstrument();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
