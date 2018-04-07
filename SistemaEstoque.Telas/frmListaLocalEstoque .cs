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
    public partial class frmListaLocalEstoque : Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public frmListaLocalEstoque()
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
            SistemaEstoque.Banco.tbLocalEstoque localEstoque = new Banco.tbLocalEstoque();

            dtGrid = localEstoque.Consulta();

            bsGrid.DataSource = dtGrid;

            grd.DataSource = bsGrid;

            grd.Columns["id"].HeaderText = "Código";
            grd.Columns["nome"].HeaderText = "Nome";

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            bsGrid.Filter = "nome like '%" + txtFiltro.Text + "%'";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmLocalEstoque frm = new frmLocalEstoque(false, null);
            frm.ShowDialog();

            PreencheGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bsGrid.Current;

            Banco.tbLocalEstoque localEstoque = new Banco.tbLocalEstoque();

            localEstoque.id = Convert.ToInt16(drv["id"]);
            localEstoque.nome = drv["nome"].ToString();

            frmLocalEstoque frm = new frmLocalEstoque(true, localEstoque);
            frm.ShowDialog();

            PreencheGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o local de estoque?", "Confirmação", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)bsGrid.Current;

                Banco.tbLocalEstoque localEstoque = new Banco.tbLocalEstoque();

                localEstoque.id = Convert.ToInt16(drv["id"]);

                localEstoque.Excluir();

                PreencheGrid();
            }
        }
    }
}
