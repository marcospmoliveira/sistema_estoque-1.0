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
    public partial class frmListaProduto : Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public frmListaProduto()
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
            SistemaEstoque.Banco.tbProduto produto = new Banco.tbProduto();

            dtGrid = produto.Consulta();

            bsGrid.DataSource = dtGrid;

            grd.DataSource = bsGrid;

            grd.Columns["id"].HeaderText = "Código";
            grd.Columns["nome"].HeaderText = "Nome";
            grd.Columns["descricao"].HeaderText = "Descrição";
            grd.Columns["peso"].HeaderText = "Peso";

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            bsGrid.Filter = "nome like '%" + txtFiltro.Text + "%'";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto(false, null);
            frm.ShowDialog();

            PreencheGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bsGrid.Current;

            Banco.tbProduto Produto = new Banco.tbProduto();

            Produto.id = Convert.ToInt16(drv["id"]);
            Produto.nome = drv["nome"].ToString();
            Produto.descricao = drv["descricao"].ToString();
            Produto.peso = Convert.ToDecimal(drv["peso"]);

            frmProduto frm = new frmProduto(true, Produto);
            frm.ShowDialog();

            PreencheGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o produto?", "Confirmação", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)bsGrid.Current;

                Banco.tbProduto Produto = new Banco.tbProduto();

                Produto.id = Convert.ToInt16(drv["id"]);

                Produto.Excluir();

                PreencheGrid();
            }
        }
    }
}
