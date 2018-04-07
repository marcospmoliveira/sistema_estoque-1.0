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
    public partial class frmListaMovimento: Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public frmListaMovimento()
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

            dtGrid = Movimentacao.Consulta();

            bsGrid.DataSource = dtGrid;

            grd.DataSource = bsGrid;

            grd.Columns["id"].HeaderText = "Código Movimentação";
            grd.Columns["id_produto"].HeaderText = "Código Produto";
            grd.Columns["Nome_produto"].HeaderText = "Produto";
            grd.Columns["id_localEstoque"].HeaderText = "Código Local de Estoque";
            grd.Columns["Nome_LocalEstoque"].HeaderText = "Local Estoque";
            grd.Columns["datahora"].HeaderText = "Data e Hora";
            grd.Columns["quantidade"].HeaderText = "Quantidade";
            grd.Columns["saida"].HeaderText = "Movimentação de Saída";
            grd.Columns["descricao"].HeaderText = "Descrição";

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            bsGrid.Filter = "descricao like '%" + txtFiltro.Text + "%'";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmMovimento frm = new frmMovimento(false, null);
            frm.ShowDialog();

            PreencheGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bsGrid.Current;

            Banco.tbMovimentacao Movimentacao = new Banco.tbMovimentacao();

            Movimentacao.id = Convert.ToInt16(drv["id"]);
            Movimentacao.id_produto = Convert.ToInt16(drv["id_produto"]);
            Movimentacao.id_localEstoque = Convert.ToInt16(drv["id_localEstoque"]);
            Movimentacao.dataHora = Convert.ToDateTime(drv["dataHora"]);
            Movimentacao.quantidade = Convert.ToDecimal(drv["quantidade"]);
            Movimentacao.saida = Convert.ToBoolean(drv["saida"]);
            Movimentacao.descricao = Convert.ToString(drv["descricao"]);

            frmMovimento frm = new frmMovimento(true, Movimentacao);
            frm.ShowDialog();

            PreencheGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o movimento?", "Confirmação", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)bsGrid.Current;

                Banco.tbMovimentacao Movimentacao = new Banco.tbMovimentacao();

                Movimentacao.id = Convert.ToInt16(drv["id"]);

                Movimentacao.Excluir();

                PreencheGrid();
            }
        }
    }
}
