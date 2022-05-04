using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_Exe2
{
    public class Cliente
    {
        public string nome;
        public string endereco;
        public string CPF;
        public string telefone;

        public Cliente(string nome, string endereco, string CPF, string telefone)
        {

            this.nome = nome;
            this.endereco = endereco;
            this.CPF = CPF;
            this.telefone = telefone;
        }
     }


}
