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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("admin"))
            {
                if (txtSenha.Text.Equals("admin"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("SENHA inválida.","TENTE NOVAMENTE!",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Clear();
                }
            }
            else
            {
                MessageBox.Show("USUÁRIO inválido.", "TENTE NOVAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Clear();
            }
        }
    }
}
