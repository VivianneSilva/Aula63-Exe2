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
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }
        List<Produto> listaProduto = new List<Produto>();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(txtIDproduto.Text, txtProduto.Text, txtCarac.Text);
            listBoxProduto.Items.Add(produto.produto);
            txtIDproduto.Clear();
            txtProduto.Clear();
            txtCarac.Clear();
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
                  
            listBoxProduto.Items.RemoveAt(listBoxProduto.SelectedIndex);
        }
      
        public void LimpaCampos()
        {
            listBoxProduto.Text = "";
           
            txtProduto.Focus();
        }


    }
}
