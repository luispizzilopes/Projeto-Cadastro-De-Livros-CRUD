using MeusLivrosCRUD.Model.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Model.TelaPrincipal
{
    internal class ModelEditar
    {
        ConexaoBd conexao = new ConexaoBd();

        public bool EditarRegistro(string busca, string nome, DateTime datalancamento, string nomeautor, string editora, DateTime datacadastro, string observacoes)
        {
            conexao.StrComando = "update TabelaLivros set nome=@nome, ano=@ano, autor=@autor, editora=@editora, datacadastro=@datacadastro, observacoes=@obs where nome=@busca";
            SqlCommand comandos = new SqlCommand(conexao.StrComando, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
            comandos.Parameters.Add("ano", System.Data.SqlDbType.Date).Value = datalancamento.ToString();
            comandos.Parameters.Add("autor", System.Data.SqlDbType.VarChar).Value = nomeautor;
            comandos.Parameters.Add("editora", System.Data.SqlDbType.VarChar).Value = editora;
            comandos.Parameters.Add("datacadastro", System.Data.SqlDbType.Date).Value = datacadastro.ToString();
            comandos.Parameters.Add("obs", System.Data.SqlDbType.VarChar).Value = observacoes;
            comandos.Parameters.Add("busca", System.Data.SqlDbType.VarChar).Value = busca;

            try
            {
                comandos.ExecuteNonQuery();
                return true; 
            }
            catch (SqlException) 
            {
                return false;
            }
        }
    }
}
