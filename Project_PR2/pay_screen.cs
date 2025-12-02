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
    public partial class pay_screen : Form
    {
        private string connectionString = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID=aluno;Password=aluno;";

        // Dados do produto
        private int instrumentID;
        private string nome;
        private string marca;
        private string categoria;
        private decimal preco;
        private int quantidade;
        private decimal total;

        public pay_screen(int instrumentID, string nome, string marca, string categoria, decimal preco, int quantidade)
        {
            InitializeComponent();

            this.instrumentID = instrumentID;
            this.nome = nome;
            this.marca = marca;
            this.categoria = categoria;
            this.preco = preco;
            this.quantidade = quantidade;
            this.total = preco * quantidade;

            // Mostrar informações na tela
            lblItem.Text = nome;
            lblPreco.Text = preco.ToString("C2");
            lblTotal.Text = total.ToString("C2");
        }

        
        private bool ProcessarCompra(string metodoPagamento)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                // UserID temporário (substitua por um valor real quando tiver login)
                int userId = 1; // <-- VALOR TEMPORÁRIO!

                // 1. Registrar compra na tabela Purchases
                string sqlCompra = @"INSERT INTO Purchases (
                                    UserID,
                                    InstrumentName, 
                                    Brand, 
                                    Category, 
                                    Price, 
                                    Quantity, 
                                    PurchaseDate,
                                    PaymentMethod
                                ) VALUES (
                                    @UserID,
                                    @InstrumentName, 
                                    @Brand, 
                                    @Category, 
                                    @Price, 
                                    @Quantity, 
                                    GETDATE(),
                                    @PaymentMethod
                                )";

                using (SqlCommand comandoCompra = new SqlCommand(sqlCompra, conexao))
                {
                    comandoCompra.Parameters.AddWithValue("@UserID", userId); // <-- UserID temporário
                    comandoCompra.Parameters.AddWithValue("@InstrumentName", nome);
                    comandoCompra.Parameters.AddWithValue("@Brand", marca);
                    comandoCompra.Parameters.AddWithValue("@Category", categoria);
                    comandoCompra.Parameters.AddWithValue("@Price", preco);
                    comandoCompra.Parameters.AddWithValue("@Quantity", quantidade);
                    comandoCompra.Parameters.AddWithValue("@PaymentMethod", metodoPagamento);

                    int linhasAfetadas = comandoCompra.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        // 2. Atualizar estoque
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

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metodoPagamento = "";

            // Verificar qual RadioButton está selecionado
            if (rbCredito.Checked)
                metodoPagamento = "Cartão de Crédito";
            else if (rbDebito.Checked)
                metodoPagamento = "Cartão de Débito";
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento!", "Atenção");
                return;
            }
            try
            {
                // EXECUTAR A COMPRA
                bool compraSucesso = ProcessarCompra(metodoPagamento);

                if (compraSucesso)
                {

                    notafiscal nota = new notafiscal(nome, marca, preco, quantidade, metodoPagamento
   );

                    nota.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar compra: {ex.Message}", "Erro");
            }
        }
    }
    }




