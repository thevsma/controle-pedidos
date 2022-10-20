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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos p = Pedidos.GetInstance();
            p.MdiParent = this;
            p.Show();
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            Produtos p1 = Produtos.GetInstance();
            p1.MdiParent = this;
            p1.Show();
        }

        private void lnkSobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lnkSobre.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/thevsma");
        }
    }
}