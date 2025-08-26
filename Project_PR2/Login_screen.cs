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
            string email = emailbtn1.Text;
            string username = Userbtn.Text;
            string senha = passbtn.Text;

            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3027881PR2;User ID=aluno;Password=aluno;";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                // código de verificação aqui
            }

            // Verifica se o email existe
            string emailCheckSql = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email";
            using (SqlCommand emailCmd = new SqlCommand(emailCheckSql, conn))
            {
                emailCmd.Parameters.AddWithValue("@Email", email);
                int emailExiste = (int)emailCmd.ExecuteScalar();

                if (emailExiste == 0)
                {
                    MessageBox.Show("Este email não está cadastrado.");
                }
                else
                {
                    // Verifica se a senha está correta
                    string senhaCheckSql = "SELECT COUNT(*) FROM Usuario WHERE Email = @Email AND PasswordHash = @Senha";
                    using (SqlCommand senhaCmd = new SqlCommand(senhaCheckSql, conn))
                    {
                        senhaCmd.Parameters.AddWithValue("@Email", email);
                        senhaCmd.Parameters.AddWithValue("@Senha", senha);

                        int loginValido = (int)senhaCmd.ExecuteScalar();

                        if (loginValido > 0)
                        {
                            Form2 product = new Form2();
                            this.Visible = false;
                            product.ShowDialog();
                            this.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta.");
                        }
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
