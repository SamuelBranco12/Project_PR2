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
        public Drums_screen ()
        {
            InitializeComponent();
           
        }

        private void Drums_screenLoad(object sender, EventArgs e)
        {
            
            CarregarTodosInstrumentos();
        }
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LojaInstrumentos;Integrated Security=True";
private DataTable dadosCompletos = new DataTable();

       


private void CarregarTodosInstrumentos()
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT InstrumentID, Name, Brand, Category, Price, QuantityInStock, CreatedAt, UpdatedAt FROM Instruments";

                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        using (System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(command))
                        {
                            dadosCompletos.Clear();
                            adapter.Fill(dadosCompletos);
                            datainstrumentview.DataSource = dadosCompletos;

                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar instrumentos: " + ex.Message);
            }
        }


        







        private void datainstrumentview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
       
        private void Drums_screen_Load(object sender, EventArgs e)
        {
           
            this.instrumentsTableAdapter1.Fill(this.cJ3022404PR2DataSet2.Instruments);

        }

        private void textpesq1_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = textpesq1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoPesquisa))
            {
                // Se estiver vazio, mostra todos os instrumentos
                datainstrumentview.DataSource = dadosCompletos;
            }
            else
            {
                // Filtra os dados
                DataTable resultados = new DataTable();
                resultados = dadosCompletos.Clone();

                foreach (DataRow row in dadosCompletos.Rows)
                {
                    bool encontrou = false;

                    // Pesquisa em Nome
                    if (row["Name"] != DBNull.Value && row["Name"].ToString().ToLower().Contains(textoPesquisa))
                        encontrou = true;
                    // Pesquisa em Marca
                    else if (row["Brand"] != DBNull.Value && row["Brand"].ToString().ToLower().Contains(textoPesquisa))
                        encontrou = true;
                    // Pesquisa em Categoria
                    else if (row["Category"] != DBNull.Value && row["Category"].ToString().ToLower().Contains(textoPesquisa))
                        encontrou = true;
                    // Pesquisa em ID
                    else if (row["InstrumentID"] != DBNull.Value && row["InstrumentID"].ToString().Contains(textoPesquisa))
                        encontrou = true;

                    if (encontrou)
                    {
                        resultados.ImportRow(row);
                    }
                }

                datainstrumentview.DataSource = resultados;
            }
        }
    }
    }




