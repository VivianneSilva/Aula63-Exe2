using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula63_Exe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            TelaProduto telaProduto = new TelaProduto();
            telaProduto.ShowDialog();
        }

        private void btnCriarLocacao_Click(object sender, EventArgs e)
        {
            CriarLocacao telaCriarLocacao = new CriarLocacao();
            telaCriarLocacao.ShowDialog();
        }
    }
}
