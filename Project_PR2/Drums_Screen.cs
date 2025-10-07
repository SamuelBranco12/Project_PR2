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
    public partial class Drums_Screen : Form
    {
        private string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID=aluno;Password=aluno;";
        private DataTable dadosCompletos = new DataTable();


        public Drums_Screen()
        {
            InitializeComponent();
        }
        private void CarregarTodosDados()
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();
                string sql = "SELECT InstrumentID, Name, Brand, Category, Price, QuantityInStock FROM Instruments";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        dadosCompletos.Clear();
                        adaptador.Fill(dadosCompletos);
                        datagridint.DataSource = dadosCompletos;
                    }
                }
            }
        }
        private void ConfigurarDataGridView()
        {
            datagridint.BackgroundColor = Color.White;
            datagridint.ForeColor = Color.Black;
            datagridint.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            datagridint.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            datagridint.DefaultCellStyle.BackColor = Color.White;
            datagridint.DefaultCellStyle.ForeColor = Color.Black;
            datagridint.DefaultCellStyle.SelectionBackColor = Color.Blue;
            datagridint.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void Drums_Screen_Load(object sender, EventArgs e)
        {

            CarregarTodosDados();
            ConfigurarDataGridView();

        }
       


        private void textpesq1_TextChanged(object sender, EventArgs e)
        {
            if (dadosCompletos.Rows.Count == 0)
            {
                CarregarTodosDados();
                return;
            }

            string pesquisa = textpesq1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(pesquisa))
            {
                datagridint.DataSource = dadosCompletos;
            }
            else
            {
                DataTable resultados = dadosCompletos.Clone();

                foreach (DataRow linha in dadosCompletos.Rows)
                {
                    if (linha["Name"] != DBNull.Value && linha["Name"].ToString().ToLower().Contains(pesquisa) ||
                        linha["Brand"] != DBNull.Value && linha["Brand"].ToString().ToLower().Contains(pesquisa) ||
                        linha["Category"] != DBNull.Value && linha["Category"].ToString().ToLower().Contains(pesquisa) ||
                        linha["InstrumentID"] != DBNull.Value && linha["InstrumentID"].ToString().Contains(pesquisa))
                    {
                        resultados.ImportRow(linha);
                    }
                }

                datagridint.DataSource = resultados;
            }
        }
        

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (datagridint.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um instrumento para comprar.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pegar dados do instrumento selecionado
            DataGridViewRow linhaSelecionada = datagridint.SelectedRows[0];

            int instrumentId = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            string nome = linhaSelecionada.Cells[1].Value.ToString();
            string marca = linhaSelecionada.Cells[2].Value.ToString();
            decimal preco = Convert.ToDecimal(linhaSelecionada.Cells[4].Value);
            int estoque = Convert.ToInt32(linhaSelecionada.Cells[5].Value);
            if (estoque <= 0)
            {
                MessageBox.Show($"Desculpe, o instrumento {nome} está fora de estoque!", "Sem Estoque",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmar compra
            string mensagem = $"CONFIRMAR COMPRA:\n\n" +
                            $"Instrumento: {nome}\n" +
                            $"Marca: {marca}\n" +
                            $"Preço: R$ {preco:F2}\n" +
                            $"Estoque Disponível: {estoque} unidades\n\n" +
                            $"Deseja confirmar a compra?";

            DialogResult resultado = MessageBox.Show(mensagem, "Confirmar Compra",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Processar compra
                ProcessarCompra(instrumentId, nome, preco);
            }
        }

        private void ProcessarCompra(int instrumentId, string nome, decimal preco)
        {
            try
            {
                string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID=aluno;Password=aluno;";

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    // Diminuir o estoque
                    string sqlAtualizarEstoque = "UPDATE Instruments SET QuantityInStock = QuantityInStock - 1 WHERE InstrumentID = @InstrumentID";

                    using (SqlCommand comando = new SqlCommand(sqlAtualizarEstoque, conexao))
                    {
                        comando.Parameters.AddWithValue("@InstrumentID", instrumentId);
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show($"✅ Compra confirmada!\n\n" +
                                          $"Instrumento: {nome}\n" +
                                          $"Valor: R$ {preco:F2}\n\n" +
                                          $"Obrigado pela compra!", "Compra Realizada",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            CarregarTodosDados();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao processar a compra. Tente novamente.", "Erro",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar compra: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void datagridint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
