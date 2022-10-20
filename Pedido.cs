using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedidosMVP
{
    internal class Pedido
    {
        public static UInt64 Serial { get; private set; }
        public UInt64 NotaFiscal { get; set; }
        public List<Item> Itens { get; set; }

        static Pedido()
        {
            StringBuilder s = new StringBuilder();
            s.Append(DateTime.Now.Year % 100);
            s.Append("000000");
            Serial = Convert.ToUInt64(s.ToString());
        }

        public Pedido()
        {
            Itens = new List<Item>();
            NotaFiscal = Serial;
            Serial += 1;
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public Decimal CalcularTotal()
        {
            Decimal total = 0;
            foreach(Item item in Itens)
            {
                total += item.CalcularTotal();
            }
            return total;
        }

        public override String ToString()
        {
            return String.Format("{0}: R${1}", NotaFiscal, CalcularTotal());
        }
    }
}
