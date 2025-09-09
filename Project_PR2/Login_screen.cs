using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            passtxt.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            passtxt.Clear();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_clock(object sender, EventArgs e)
        {
            usertxt.Clear();

        }

        private void Login_screen_Load(object sender, EventArgs e)
        {

        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            string username = usertxt.Text.Trim(); // Nome de usuário
            string senha = passtxt.Text;

            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Busca o hash da senha do usuário
                string verificasql = "SELECT PasswordHash FROM USERS WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(verificasql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string storedHash = result.ToString();
                        string inputHash = GerarHash(senha); // Gera hash da senha digitada

                        // Compara os hashes
                        if (storedHash.Equals(inputHash, StringComparison.OrdinalIgnoreCase))
                        {
                            Buy_or_RegisterInstrument product = new Buy_or_RegisterInstrument();
                            this.Visible = false;
                            product.ShowDialog();
                            this.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Nome de usuário ou senha incorretos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário ou senha incorretos");
                    }
                }
            }
        }
        

            
// Função para gerar hash (DEVE SER A MESMA USADA NO CADASTRO)
private string GerarHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            register product = new register();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
    }

