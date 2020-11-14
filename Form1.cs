using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(txbnome_produto.Text, txbvalor.Text, txbdata_vencimento.Text);
            MessageBox.Show(cad.mensagem);

        }
    }
}
