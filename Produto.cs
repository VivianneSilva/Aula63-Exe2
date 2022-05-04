using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_Exe2
{
    internal class Produto
    {
        public string ID { get; set; }
        public string produto;
        public string caracteristica;

        public Produto(string ID, string produto, string caracteristica)
        {
            this.ID = ID;
            this.produto = produto;
            this.caracteristica = caracteristica;
        }
       
    }
}
