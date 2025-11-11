using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private void ComprarInstrumento(int instrumentID, int quantidade)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    // 1. Buscar dados completos do instrumento
                    string sqlInstrumento = @"SELECT Name, Brand, Category, Price, QuantityInStock 
                                     FROM Instruments WHERE InstrumentID = @InstrumentID";

                    string nome = "", marca = "", categoria = "";
                    decimal preco = 0;
                    int estoqueAtual = 0;

                    using (SqlCommand comandoInstrumento = new SqlCommand(sqlInstrumento, conexao))
                    {
                        comandoInstrumento.Parameters.AddWithValue("@InstrumentID", instrumentID);

                        using (SqlDataReader reader = comandoInstrumento.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nome = reader["Name"].ToString();
                                marca = reader["Brand"].ToString();
                                categoria = reader["Category"].ToString();
                                preco = Convert.ToDecimal(reader["Price"]);
                                estoqueAtual = Convert.ToInt32(reader["QuantityInStock"]);
                            }
                            else
                            {
                                MessageBox.Show("Instrumento não encontrado!");
                                return;
                            }
                        }
                    }

                    if (estoqueAtual < quantidade)
                    {
                        MessageBox.Show($"Estoque insuficiente! Disponível: {estoqueAtual} unidades",
                            "Studio Shodwe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 2. Registrar compra na tabela Purchases
                    string sqlCompra = @"INSERT INTO Purchases (
                                UserID,
                                InstrumentName, 
                                Brand, 
                                Category, 
                                Price, 
                                Quantity, 
                                PurchaseDate
                            ) VALUES (
                                @UserID,
                                @InstrumentName, 
                                @Brand, 
                                @Category, 
                                @Price, 
                                @Quantity, 
                                GETDATE()
                            )";

                    using (SqlCommand comandoCompra = new SqlCommand(sqlCompra, conexao))
                    {
                        comandoCompra.Parameters.AddWithValue("@UserID", UserSession.UserID);
                        comandoCompra.Parameters.AddWithValue("@InstrumentName", nome);
                        comandoCompra.Parameters.AddWithValue("@Brand", marca);
                        comandoCompra.Parameters.AddWithValue("@Category", categoria);
                        comandoCompra.Parameters.AddWithValue("@Price", preco);
                        comandoCompra.Parameters.AddWithValue("@Quantity", quantidade);

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

                            decimal total = preco * quantidade;

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
                int instrumentID = Convert.ToInt32(row.Cells[0].Value);
                int quantidade = 1; // Ou obter de um controle NumericUpDown, se houver

                ComprarInstrumento(instrumentID, quantidade);
            }
        }


    }
        }


    




