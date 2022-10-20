using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePedidosMVP
{
    public partial class CadastroItem : Form
    {
        Pedido p = new Pedido();
        private static CadastroItem instance;
        public CadastroItem()
        {
            InitializeComponent();
        }

        public static CadastroItem GetInstance()
        {
            if(instance == null)
            {
                instance = new CadastroItem();
            }
            if (instance.IsDisposed)
            {
                instance = new CadastroItem();
            }
            return instance;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lstProdutos.DataSource = BancoDadosSimulado.LocalizarNome(txtNome.Text);
            }
            catch
            {
                lstProdutos.DataSource = BancoDadosSimulado.Produtos;
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            List<Produto> list = new List<Produto>();

            try
            {
                list.Add(BancoDadosSimulado.LocalizarCodigo(Convert.ToUInt64(txtCod.Text)));
                lstProdutos.DataSource = list;
            }
            catch
            {
                list.Clear();
                lstProdutos.DataSource = BancoDadosSimulado.Produtos;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
            if(lstProdutos.SelectedIndex >= -1)
            {
                Item item = new Item(Convert.ToUInt16(numQuant.Value), (Produto)lstProdutos.SelectedItem);
                p.AdicionarItem(item);
                lstItens.Items.Add(item);
                lblTotal.Text = Convert.ToString("Total: R$" + p.CalcularTotal());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(lstItens.Items.Count > 0)
            {
                Pedido p1 = new Pedido();

                foreach(Item i in p.Itens)
                {
                    p1.AdicionarItem(i);
                }

                BancoDadosSimulado.Pedidos.Add(p1);
                p.Itens.Clear();
                lstItens.Items.Clear();
                lblTotal.Text = "Total: R$ ---";
            }
        }
    }
}
