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
    public partial class Register_instrument_screen : Form
    {
        public Register_instrument_screen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_InstrumentBtn_Click(object sender, EventArgs e)
        {
            string name = Nametxb.Text;
            string brand = Brandtxb.Text;
            string category = Categtxb.Text;
            decimal price = decimal.Parse(PriceTxb.Text);
            int quantity = int.Parse(InStocktxb.Text);

            string conexao = "Data Source=sqlexpress;Initial Catalog=CJ3022404PR2;User ID=aluno;Password=aluno;";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                // Verifica se o instrumento já existe pelo nome e marca
                string verificaSql = "SELECT COUNT(*) FROM Instruments WHERE Name = @Name AND Brand = @Brand";
                using (SqlCommand verificaCmd = new SqlCommand(verificaSql, conn))
                {
                    verificaCmd.Parameters.AddWithValue("@Name", name);
                    verificaCmd.Parameters.AddWithValue("@Brand", brand);
                    int count = (int)verificaCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        // Inserir novo instrumento
                        string insertSql = @"
                INSERT INTO Instruments (Name, Brand, Category, Price, QuantityInStock, CreatedAt)
                VALUES (@Name, @Brand, @Category, @Price, @QuantityInStock, @CreatedAt)";

                        using (SqlCommand insertCmd = new SqlCommand(insertSql, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Name", name);
                            insertCmd.Parameters.AddWithValue("@Brand", brand);
                            insertCmd.Parameters.AddWithValue("@Category", category);
                            insertCmd.Parameters.AddWithValue("@Price", price);
                            insertCmd.Parameters.AddWithValue("@QuantityInStock", quantity);
                            insertCmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                            insertCmd.ExecuteNonQuery();

                            // Mensagem de sucesso
                            MessageBox.Show("Instrument registered successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This instrument is already registered.");
                    }
                }
            }
        }
            

        private void Register_instrument_screen_Load(object sender, EventArgs e)
        {

        }

        private void Brandtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Categtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void InStocktxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buy_or_RegisterInstrument product = new Buy_or_RegisterInstrument();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
