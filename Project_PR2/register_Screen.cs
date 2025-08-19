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
    public partial class register_Screen : Form
    {
        public register_Screen()
        {
            InitializeComponent();
        }

        

       

        
      
        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string email = TextEmail.Text;
            string senha = TextSenha.Text;

            // Gera o hash da senha
            string passwordHash = ComputeSha256Hash(senha);

            string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO USERS (Username, Email, PasswordHash) VALUES (@Username, @Email, @PasswordHash)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                    }
                }
            

// Função para gerar hash SHA256
private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}

        }
        

