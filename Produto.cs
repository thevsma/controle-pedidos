using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedidosMVP
{
    internal class Produto
    {
        public UInt64 Codigo { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }

        public Produto()
        {
            Codigo = 0;
            Preco = 0;
        }

        public Produto(UInt64 codigo, String nome, Decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public override String ToString()
        {
            return String.Format("{0} [R${1}]", Nome, Preco);
        }
    }
}
