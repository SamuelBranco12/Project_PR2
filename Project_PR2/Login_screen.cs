using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string email = textBox2.Text;
            string senha = textBox1.Text;

            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID = aluno; Password = aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                string verificasql = "SELECT COUNT(*) FROM USERS WHERE Email = @Email AND PasswordHash = @PasswordHash";

                using (SqlCommand cmd = new SqlCommand(verificasql, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", senha); 

                    int existe = (int)cmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        Buy_or_RegisterInstrument product = new Buy_or_RegisterInstrument();
                        this.Visible = false;
                        product.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Email ou Senha incorretos");
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            register product = new register ();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void Login_screen_Load(object sender, EventArgs e)
        {

        }
    }
}
