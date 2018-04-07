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
    public partial class frmMovimento : Form
    {
        private bool estaAlterando = false;
        private Banco.tbMovimentacao Movimentacao;

        public frmMovimento(bool estaAlterando, Banco.tbMovimentacao Movimentacao)
        {
            InitializeComponent();

            this.estaAlterando = estaAlterando;
            this.Movimentacao = Movimentacao;

            Banco.tbProduto Produto = new Banco.tbProduto();
            cboProduto.DataSource = Produto.Consulta();
            cboProduto.DisplayMember = "nome";
            cboProduto.ValueMember = "id";

            Banco.tbLocalEstoque LocalEstoque = new Banco.tbLocalEstoque();
            cboLocalEstoque.DataSource = LocalEstoque.Consulta();
            cboLocalEstoque.DisplayMember = "nome";
            cboLocalEstoque.ValueMember = "id";

            if (this.estaAlterando)
            {
                txtDescricao.Text = Movimentacao.descricao;
                txtQuantidade.Text = Convert.ToString(Movimentacao.quantidade);
                chkSaida.Checked = Movimentacao.saida;
                dtpDataHora.Value = Movimentacao.dataHora;
                cboProduto.SelectedValue = Movimentacao.id_produto;
                cboLocalEstoque.SelectedValue = Movimentacao.id_localEstoque;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.estaAlterando)
            {
                Movimentacao.descricao = txtDescricao.Text;
                Movimentacao.quantidade = Convert.ToDecimal(txtQuantidade.Text);
                Movimentacao.saida = chkSaida.Checked;
                Movimentacao.dataHora = dtpDataHora.Value;
                Movimentacao.id_produto = Convert.ToInt16(cboProduto.SelectedValue);
                Movimentacao.id_localEstoque = Convert.ToInt16(cboLocalEstoque.SelectedValue);

                this.Movimentacao.Alterar();
            }
            else
            {
                this.Movimentacao = new Banco.tbMovimentacao();

                Movimentacao.descricao = txtDescricao.Text;
                Movimentacao.quantidade = Convert.ToDecimal(txtQuantidade.Text);
                Movimentacao.saida = chkSaida.Checked;
                Movimentacao.dataHora = dtpDataHora.Value;
                Movimentacao.id_produto = Convert.ToInt16(cboProduto.SelectedValue);
                Movimentacao.id_localEstoque = Convert.ToInt16(cboLocalEstoque.SelectedValue);

                this.Movimentacao.Inserir();
            }

            this.Close();
        }
    }
}
