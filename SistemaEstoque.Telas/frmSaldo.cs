using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class frmSaldo : Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public frmSaldo()
        {
            InitializeComponent();
            PreencheGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencheGrid()
        {
            SistemaEstoque.Banco.tbMovimentacao Movimentacao = new Banco.tbMovimentacao();

            dtGrid = Movimentacao.ConsultaSaldo();

            bsGrid.DataSource = dtGrid;

            grd.DataSource = bsGrid;

            grd.Columns["id_produto"].HeaderText = "Código Produto";
            grd.Columns["Nome_produto"].HeaderText = "Produto";
            grd.Columns["id_localEstoque"].HeaderText = "Código Local de Estoque";
            grd.Columns["Nome_LocalEstoque"].HeaderText = "Local Estoque";
            grd.Columns["saldo"].HeaderText = "Saldo em Estoque";

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            bsGrid.Filter = "Nome_produto like '%" + txtFiltro.Text + "%' or Nome_localEstoque like '%" + txtFiltro.Text + "%'";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmMovimento frm = new frmMovimento(false, null);
            frm.ShowDialog();

            PreencheGrid();
        }
    }
}
