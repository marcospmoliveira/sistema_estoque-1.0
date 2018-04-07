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
    public partial class frmProduto : Form
    {
        private bool estaAlterando = false;
        private Banco.tbProduto Produto;

        public frmProduto(bool estaAlterando, Banco.tbProduto Produto)
        {
            InitializeComponent();

            this.estaAlterando = estaAlterando;
            this.Produto = Produto;

            if (this.estaAlterando)
            {
                txtNome.Text = Produto.nome;
                txtDescricao.Text = Produto.descricao;
                txtPeso.Text = Produto.peso.ToString();
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
                this.Produto.nome = txtNome.Text;
                this.Produto.descricao = txtDescricao.Text;
                this.Produto.peso = Convert.ToDecimal(txtPeso.Text);

                this.Produto.Alterar();
            }
            else
            {
                this.Produto = new Banco.tbProduto();
                this.Produto.nome = txtNome.Text;
                this.Produto.descricao = txtDescricao.Text;
                this.Produto.peso = Convert.ToDecimal(txtPeso.Text);

                this.Produto.Inserir();
            }

            this.Close();
        }
    }
}
