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
    public partial class frmLocalEstoque : Form
    {
        private bool estaAlterando = false;
        private Banco.tbLocalEstoque LocalEstoque;

        public frmLocalEstoque(bool estaAlterando, Banco.tbLocalEstoque LocalEstoque)
        {
            InitializeComponent();

            this.estaAlterando = estaAlterando;
            this.LocalEstoque = LocalEstoque;

            if (this.estaAlterando)
            {
                txtNome.Text = LocalEstoque.nome;
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
                this.LocalEstoque.nome = txtNome.Text;
                
                this.LocalEstoque.Alterar();
            }
            else
            {
                this.LocalEstoque = new Banco.tbLocalEstoque();

                this.LocalEstoque.nome = txtNome.Text;

                this.LocalEstoque.Inserir();
            }

            this.Close();
        }
    }
}
