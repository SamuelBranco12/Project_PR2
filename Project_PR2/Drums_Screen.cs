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

namespace Project_PR2
{
    public partial class Drums_screen : Form
    {
        public Drums_screen()
        {
            InitializeComponent();
        }

        private void Drums_Screen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = textpesq1.Text; // Sua TextBox de pesquisa
            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3022U@MPR2;User ID=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Query para pesquisar instrumentos
                string pesquisaSql = @"
        SELECT * FROM Instrumentos 
        WHERE Nome LIKE @Termo 
           OR Marca LIKE @Termo 
           OR Descricao LIKE @Termo 
           OR Categoria LIKE @Termo";

                using (SqlCommand pesquisaCmd = new SqlCommand(pesquisaSql, conn))
                {
                    pesquisaCmd.Parameters.AddWithValue("@Termo", $"%{termoPesquisa}%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(pesquisaCmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Exibir resultados no DataGridView
                        dataGridViewinstruments.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show($"{dt.Rows.Count} instrumento(s) encontrado(s)!", "Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhum instrumento encontrado.", "Resultado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}