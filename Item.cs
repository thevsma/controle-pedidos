using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedidosMVP
{
    internal class Item
    {
        public UInt16 Quantidade { get; set; }
        public Produto Produto { get; set; }

        public Item()
        {
            Quantidade = 1;
            Produto = new Produto();
        }

        public Item(UInt16 quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }

        public Decimal CalcularTotal()
        {
            return Quantidade * Produto.Preco;
        }

        public override String ToString()
        {
            return String.Format("{0} x {1} [R${2}] = R${3}", Quantidade, Produto.Nome, Produto.Preco, CalcularTotal());
        }
    }
}
