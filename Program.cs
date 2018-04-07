using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                SistemaEstoque.Utilitarios.ConexaoBanco.conexao = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["conexaoBDSistemaEstoque"].ConnectionString);
                SistemaEstoque.Utilitarios.ConexaoBanco.conexao.Open();

                Application.Run(new frmPrincipal());
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
