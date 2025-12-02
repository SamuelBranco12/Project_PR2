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
    public partial class notafiscal : Form
        
    {
        public notafiscal(string nomeProduto, string marca, decimal preco,
                        int quantidade, string metodoPagamento)
        {
            InitializeComponent();

            decimal total = preco * quantidade;

            // Criar texto da nota
            string nota = $"STUDIO SHODWE - NOTA FISCAL\n\n" +
                         $"Data: {DateTime.Now:dd/MM/yyyy HH:mm}\n" +
                         $"Cliente: Cliente\n\n" +
                         $"Produto: {nomeProduto}\n" +
                         $"Marca: {marca}\n" +
                         $"Preço: {preco:C2}\n" +
                         $"Quantidade: {quantidade}\n" +
                         $"Total: {total:C2}\n" +
                         $"Pagamento: {metodoPagamento}\n\n" +
                         $"Obrigado pela sua compra!";

            // Se você tiver um Label chamado lblNotaCompleta
            lblNotaCompleta.Text = nota;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notafiscal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Drums_screen product = new Drums_screen();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}