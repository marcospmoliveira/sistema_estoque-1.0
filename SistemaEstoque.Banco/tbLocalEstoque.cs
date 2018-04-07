using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque.Banco
{
    public class tbLocalEstoque
    {
        public int id { get; set; }
        public string nome { get; set; }

        public bool Inserir()
        {

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "INSERT INTO tblLocalEstoque VALUES (@nome)";

                comando.Parameters.AddWithValue("@nome", nome);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o local de estoque. Descrição " + ex.Message.ToString());
                return false;
            }

        }

        public bool Alterar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "UPDATE tblLocalEstoque SET nome = @nome where id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", nome);
                
                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o local de estoque. Descrição " + ex.Message.ToString());
                return false;
            }
        }

        public bool Excluir()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "DELETE FROM tblLocalEstoque where id = @id";

                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o local de estoque. Descrição " + ex.Message.ToString());
                return false;
            }
        }

        public DataTable Consulta()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "SELECT * FROM tblLocalEstoque";

                DataTable dtRetorno = new DataTable();
                dtRetorno.Load(comando.ExecuteReader());
                return dtRetorno;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o local de estoque. Descrição " + ex.Message.ToString());
                return null;
            }
        }
    }
}
