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
    public partial class PreferredInstrument_screen : Form
    {
        public PreferredInstrument_screen()
        {
            InitializeComponent();
        }

        private void PreferredInstrument_screen_Load(object sender, EventArgs e)
        {

        }

        private void Drumbtn_Click(object sender, EventArgs e)
        {
           Drums_Screen product = new Drums_Screen();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void AcousticGuitarbtn_Click(object sender, EventArgs e)
        {
           AcousticGuitar_Screen product = new AcousticGuitar_Screen();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void Guitarbtn_Click(object sender, EventArgs e)
        {
            Guitar_Screen product = new Guitar_Screen();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
