using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePedidosMVP
{
    internal class BancoDadosSimulado
    {
        public static BindingList<Pedido> Pedidos { get; set; }
        public static List<Produto> Produtos { get; set; }

        static BancoDadosSimulado()
        {
            Produtos = new List<Produto>();
            Pedidos = new BindingList<Pedido>(); 
            
            Produtos.Add(new Produto(1, "Banana", 5.59m));
            Produtos.Add(new Produto(2, "Maçã", 7.27m));
            Produtos.Add(new Produto(3, "Melancia", 3.85m));
            Produtos.Add(new Produto(4, "Mamão", 8.57m));
            Produtos.Add(new Produto(5, "Whey", 95.98m));
            Produtos.Add(new Produto(6, "Açaí", 14.90m));
            Produtos.Add(new Produto(7, "Bolacha", 2.50m));
            Produtos.Add(new Produto(8, "Aveia", 17.15m));
            Produtos.Add(new Produto(9, "Pasta de Amendoim", 21.39m));
            Produtos.Add(new Produto(10, "Cereal", 18.90m));
        }

        public static Produto LocalizarCodigo(UInt64 codigo)
        {
            Produto pesquisa = new Produto();
            
            foreach (Produto produto in Produtos)
            {
                if(produto.Codigo == codigo)
                {
                    pesquisa = produto;
                }
            }
            return pesquisa;
        }

        public static List<Produto> LocalizarNome(String parte)
        {
            List<Produto> pesquisa = new List<Produto>();

            foreach(Produto produto in Produtos)
            {
                if (produto.Nome.ToLower().Contains(parte.ToLower()))
                {
                    pesquisa.Add(produto);
                }
            }
            return pesquisa;
        }
    }
}
