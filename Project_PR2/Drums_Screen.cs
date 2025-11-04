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
        private string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID=aluno;Password=aluno;";
        private DataTable dadosCompletos = new DataTable();

        public Drums_screen()
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
        string sqlexpress = @"INSERT INTO Purchases (UserID, InstrumentID, ProductName, Price, Quantity, Total, PurchaseDate)
                     VALUES (@UserID, @InstrumentID, @ProductName, @Price, @Quantity, @Total, GETDATE())";
        private void ComprarInstrumento(int instrumentID, string nome, decimal preco, int quantidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    // 1. Verificar estoque
                    string sqlEstoque = "SELECT QuantityInStock FROM Instruments WHERE InstrumentID = @InstrumentID";
                    int estoqueAtual = 0;

                    using (SqlCommand comandoEstoque = new SqlCommand(sqlEstoque, conexao))
                    {
                        comandoEstoque.Parameters.AddWithValue("@InstrumentID", instrumentID);
                        estoqueAtual = (int)comandoEstoque.ExecuteScalar();
                    }

                    if (estoqueAtual < quantidade)
                    {
                        MessageBox.Show($"Estoque insuficiente! Disponível: {estoqueAtual} unidades",
                            "Studio Shodwe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 2. Registrar compra na tabela Purchases
                    string sqlCompra = @"INSERT INTO Purchases (UserID, InstrumentID, ProductName, Price, Quantity, Total, PurchaseDate)
                                 VALUES (@UserID, @InstrumentID, @ProductName, @Price, @Quantity, @Total, GETDATE())";

                    decimal total = preco * quantidade;

                    using (SqlCommand comandoCompra = new SqlCommand(sqlCompra, conexao))
                    {
                        comandoCompra.Parameters.AddWithValue("@UserID", UserSession.UserID);
                        comandoCompra.Parameters.AddWithValue("@InstrumentID", instrumentID);
                        comandoCompra.Parameters.AddWithValue("@ProductName", nome);
                        comandoCompra.Parameters.AddWithValue("@Price", preco);
                        comandoCompra.Parameters.AddWithValue("@Quantity", quantidade);
                        comandoCompra.Parameters.AddWithValue("@Total", total);

                        int linhasAfetadas = comandoCompra.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            // 3. Atualizar estoque
                            string sqlUpdate = @"UPDATE Instruments 
                                        SET QuantityInStock = QuantityInStock - @Quantidade, 
                                            UpdatedAt = GETDATE()
                                        WHERE InstrumentID = @InstrumentID";

                            using (SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao))
                            {
                                comandoUpdate.Parameters.AddWithValue("@Quantidade", quantidade);
                                comandoUpdate.Parameters.AddWithValue("@InstrumentID", instrumentID);
                                comandoUpdate.ExecuteNonQuery();
                            }

                            MessageBox.Show($"✅ Compra realizada com sucesso!\n\n" +
                                          $"📦 {quantidade}x {nome}\n" +
                                          $"💵 Total: {total:C2}",
                                          "Studio Shodwe - Compra Concluída",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Atualizar a lista de instrumentos
                            CarregarTodosDados();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Erro ao processar compra: {ex.Message}",
                              "Studio Shodwe - Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
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


       
         

        private void datagridint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (datagridint.CurrentRow != null)
            {
                DataGridViewRow row = datagridint.CurrentRow;

                // ✅ Obter valores corretamente
                int instrumentID = Convert.ToInt32(row.Cells["InstrumentID"].Value);
                string nome = row.Cells["Name"].Value.ToString();
                decimal preco = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantidade = 1; // Ou do NumericUpDown

                // ✅ Chamar o método
                ComprarInstrumento(instrumentID, nome, preco, quantidade);


            }
        }

    }
}

    




