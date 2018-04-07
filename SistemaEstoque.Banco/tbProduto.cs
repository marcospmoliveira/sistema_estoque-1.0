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
    public class tbProduto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal peso { get; set; }

        public bool Inserir()
        {

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "INSERT INTO tblProduto VALUES (@nome, @descricao, @peso)";

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@descricao", descricao);
                comando.Parameters.AddWithValue("@peso", peso);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o produto. Descrição " + ex.Message.ToString());
                return false;
            }
            
        }

        public bool Alterar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "UPDATE tblProduto SET nome = @nome, descricao = @descricao, peso = @peso where id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@descricao", descricao);
                comando.Parameters.AddWithValue("@peso", peso);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o produto. Descrição " + ex.Message.ToString());
                return false;
            }
        }

        public bool Excluir()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "DELETE FROM tblProduto WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o produto. Descrição " + ex.Message.ToString());
                return false;
            }
        }

        public DataTable Consulta()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "SELECT * FROM tblProduto";

                DataTable dtRetorno = new DataTable();
                dtRetorno.Load(comando.ExecuteReader());
                return dtRetorno;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o produto. Descrição " + ex.Message.ToString());
                return null;
            }
        }

    }
}
