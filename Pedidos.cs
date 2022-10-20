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
    public partial class Pedidos : Form
    {
        private static Pedidos instance;

        public Pedidos()
        {
            InitializeComponent();

            lstPedidos.DataSource = BancoDadosSimulado.Pedidos;
        }

        public static Pedidos GetInstance()
        {
            if(instance == null)
            {
                instance = new Pedidos();
            }
            if (instance.IsDisposed)
            {
                instance = new Pedidos();
            }
            return instance;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastroItem c = CadastroItem.GetInstance();
            c.MdiParent = this.MdiParent;
            c.Show();
        }
    }
}
