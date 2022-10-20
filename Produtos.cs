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
    public partial class Produtos : Form
    {
        private static Produtos instance;
        public Produtos()
        {
            InitializeComponent();

            lstProdutos.DataSource = BancoDadosSimulado.Produtos;
        }

        public static Produtos GetInstance()
        {
            if (instance == null)
            {
                instance = new Produtos();
            }
            if (instance.IsDisposed)
            {
                instance = new Produtos();
            }
            return instance;
        }
    }
}
