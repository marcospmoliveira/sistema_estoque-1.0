using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.frmListaProduto frm = new Telas.frmListaProduto();
            frm.Show();
        }

        private void localDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.frmListaLocalEstoque frm = new Telas.frmListaLocalEstoque();
            frm.Show();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.frmListaMovimento frm = new Telas.frmListaMovimento();
            frm.Show();
        }

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.frmSaldo frm = new Telas.frmSaldo();
            frm.Show();
        }
    }
}
