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
   
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {
        }
        List<Cliente> listaCliente = new List<Cliente>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, txtCPF.Text, txtEndereco.Text, txtTelefone.Text);
            listaCliente.Add(cliente);
            txtNome.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
        }
    }
}
