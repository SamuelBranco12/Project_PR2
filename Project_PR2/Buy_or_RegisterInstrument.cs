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
    public partial class Buy_or_RegisterInstrument : Form
    {
        public Buy_or_RegisterInstrument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Drums_screen product = new Drums_screen();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void Buy_or_RegisterInstrument_Load(object sender, EventArgs e)
        {

        }

        private void Register_Instrumentbtn_Click(object sender, EventArgs e)
        {
            Register_instrument_screen product = new Register_instrument_screen();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
