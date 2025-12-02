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

            }
        }


    }
        }


    




