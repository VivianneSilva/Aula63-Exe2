using System;
using System.Collections;
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
    public partial class CriarLocacao : Form
    {
        public CriarLocacao()
        {
            InitializeComponent();
        }

      

        private void btnGerarLocacao_Click(object sender, EventArgs e)
        {
           
        }

        private void CriarLocacao_Load(object sender, EventArgs e)
        {
            ArrayList cliente = new ArrayList();
            cliente.Add(new Cliente(426,"Viviane"));
            cliente.Add(new Cliente(218, "Rafael"));
            cliente.Add(new Cliente(104, "Paulo"));

            ckbCliente.DataSource = cliente;
            ckbCliente.DisplayMember = "Name";
            ckbCliente.ValueMember = "ID";

            ArrayList produto = new ArrayList();
            produto.Add(new Produto(1, "ContainerAzul"));
            produto.Add(new Produto(2, "ContainerVermelho"));
            produto.Add(new Produto(3, "BanheiroPortatil"));

            ckbproduto.DataSource = produto;
            ckbproduto.DisplayMember = "Name";
            ckbproduto.ValueMember = "ID";


        }
        public class Produto
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Produto(int ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }
        }
        public class Cliente
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Cliente(int ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }
        }

        private void rdbAvista_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAvista.Checked)
            {
                lbltotal.Text = txtValor.Text;
            }

        }

        private void rdbPix_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPix.Checked)
            {
                int randNum = new Random().Next(1000000, 99999999);
                lblChavePix.Text = (randNum.ToString());
                    
            }
            
            
        }
        private void rdbBoleto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBoleto.Checked)
            {
                lbltotal.Text = txtValor.Text;

            }
        }

        private void ckbproduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }
       
    }
}
