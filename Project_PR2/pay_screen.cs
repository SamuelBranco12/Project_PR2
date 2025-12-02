using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PR2
{
    public partial class pay_screen : Form
    {
      
            public pay_screen(string nome, string marca, string categoria, decimal preco, int quantidade, string metodoPagamento)
        {
            InitializeComponent();
            GerarNotaFiscal(nome, marca, categoria, preco, quantidade, metodoPagamento);
        }

        private void GerarNotaFiscal(string nome, string marca, string categoria, decimal preco, int quantidade, string metodoPagamento)
        {
            decimal total = preco * quantidade;

            // Se UserSession não existe, use um valor padrão
            string username = "Cliente";
            string email = "cliente@email.com";

            // Se UserSession existe, use os dados reais
            // string username = UserSession.Username;
            // string email = UserSession.Email;

            string nota = $@"================================
        STUDIO SHODWE
        NOTA FISCAL
================================

Data: {DateTime.Now:dd/MM/yyyy HH:mm}

Cliente: {username}
Email: {email}

--------------------------------
PRODUTO: {nome}
MARCA: {marca}
CATEGORIA: {categoria}
QUANTIDADE: {quantidade}
PREÇO UNITÁRIO: {preco:C2}
TOTAL: {total:C2}
FORMA DE PAGAMENTO: {metodoPagamento}
--------------------------------

Obrigado pela sua compra!

================================
Studio Shodwe
================================
";

            rtbNota.Text = nota;
        }

       
        

        private void pay_screen_Load(object sender, EventArgs e)
        {
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        

    