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
    public class tbMovimentacao
    {
        public int id { get; set; }
        public int id_produto { get; set; }
        public int id_localEstoque { get; set; }
        public DateTime dataHora { get; set; }
        public decimal quantidade  { get; set; }
        public bool saida { get; set; }
        public string descricao { get; set; }

        public bool Inserir()
        {

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "INSERT INTO tblMovimentacao VALUES (@id_produto, @id_localEstoque, @dataHora, @quantidade, @saida, @descricao)";

                comando.Parameters.AddWithValue("@id_produto", id_produto);
                comando.Parameters.AddWithValue("@id_localEstoque", id_localEstoque);
                comando.Parameters.AddWithValue("@dataHora", dataHora);
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@saida", saida);
                comando.Parameters.AddWithValue("@descricao", descricao);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir a movimentação. Descrição " + ex.Message.ToString());
                return false;
            }

        }

        public bool Alterar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "UPDATE tblMovimentacao SET id_produto = @id_produto, id_localEstoque = @id_localEstoque, dataHora = @dataHora, quantidade = @quantidade, saida = @saida, descricao = @descricao where id = @id";

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@id_produto", id_produto);
                comando.Parameters.AddWithValue("@id_localEstoque", id_localEstoque);
                comando.Parameters.AddWithValue("@dataHora", dataHora);
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@saida", saida);
                comando.Parameters.AddWithValue("@descricao", descricao);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a movimentação. Descrição " + ex.Message.ToString());
                return false;
            }
        }

        public bool Excluir()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "DELETE FROM tblMovimentacao where id = @id";

                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a movimentação. Descrição " + ex.Message.ToString());
                return false;
            }
        }

        public DataTable Consulta()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = "select " +
                                        " Mov.id, " +
                                        " Mov.id_produto, " +
                                        " Prod.nome as Nome_Produto, " +
                                        " Mov.id_localEstoque, " +
                                        " Loc.nome as Nome_LocalEstoque, " +
                                        " Mov.datahora, " +
                                        " Mov.descricao, " +
                                        " Mov.quantidade, " + 
                                        " Mov.saida " +
                                        " from tblMovimentacao as Mov " +
                                        " inner join tblProduto as Prod on Prod.id = id_produto " +
                                        " inner join tblLocalEstoque as Loc on Loc.id = id_localEstoque";

                DataTable dtRetorno = new DataTable();
                dtRetorno.Load(comando.ExecuteReader());
                return dtRetorno;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a movimentação. Descrição " + ex.Message.ToString());
                return null;
            }
        }

        public DataTable ConsultaSaldo()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                comando.CommandText = " select " +
                                        " Mov.id_produto, " +
                                        " Prod.nome as Nome_Produto, " +
                                        " Mov.id_localEstoque, " +
                                        " Loc.nome as Nome_LocalEstoque, " +
                                        " SUM( " +
                                            "case when Mov.saida = 1 then(- Mov.quantidade) " +
                                            "else Mov.quantidade end ) as saldo " +
                                        " from tblMovimentacao as Mov " +
                                        " inner join tblProduto as Prod on Prod.id = id_produto " +
                                        " inner join tblLocalEstoque as Loc on Loc.id = id_localEstoque " +
                                        " group by Mov.id_produto, Prod.nome, Mov.id_localEstoque, Loc.nome" +
                                        " order by Prod.nome, Loc.nome ";

                DataTable dtRetorno = new DataTable();
                dtRetorno.Load(comando.ExecuteReader());
                return dtRetorno;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o saldo do estoque. Descrição " + ex.Message.ToString());
                return null;
            }
        }
    }
}
