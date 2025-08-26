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

namespace Project_PR2
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailbtn1.Text;
            string username = Userbtn.Text;
            string senha = passbtn.Text;


            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID = aluno; Password = aluno;";

            // Gerar hash da senha
            string senhaHash = GerarHash(senha);

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Verifica se o email já existe
                string verificaSql = "SELECT COUNT(*) FROM USERS WHERE Email=@Email";
                using (SqlCommand verificaCmd = new SqlCommand(verificaSql, conn))
                {
                    verificaCmd.Parameters.AddWithValue("@Email", email);
                    int count = (int)verificaCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        // Inserir novo usuário
                        string insertSql = "INSERT INTO USERS (Username, Email, PasswordHash, CreatedAt) VALUES (@Username, @Email, @PasswordHash, @CreatedAt)";
                        using (SqlCommand insertCmd = new SqlCommand(insertSql, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Username", username);
                            insertCmd.Parameters.AddWithValue("@Email", email);
                            insertCmd.Parameters.AddWithValue("@PasswordHash", senhaHash);
                            insertCmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                            insertCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este e-mail já está cadastrado.");
                    }
                }
            }
        }

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

        private void Userbtn_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }

        
    }

