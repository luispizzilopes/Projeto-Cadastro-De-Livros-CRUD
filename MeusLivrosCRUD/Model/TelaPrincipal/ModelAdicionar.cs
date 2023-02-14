using MeusLivrosCRUD.Model.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Model.TelaPrincipal
{
    internal class ModelAdicionar
    {
        ConexaoBd conexao = new ConexaoBd();

        public bool AdicionarLivro(string nome, DateTime datalancamento, string nomeautor, string editora, DateTime datacadastro, string observacoes)
        {
            conexao.StrComando = "insert into TabelaLivros values (@nome, @ano, @autor, @editora, @datacadastro, @obs)";
            SqlCommand comandos = new SqlCommand(conexao.StrComando, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
            comandos.Parameters.Add("ano", System.Data.SqlDbType.Date).Value = datalancamento.ToString();
            comandos.Parameters.Add("autor", System.Data.SqlDbType.VarChar).Value = nomeautor;
            comandos.Parameters.Add("editora", System.Data.SqlDbType.VarChar).Value = editora;
            comandos.Parameters.Add("datacadastro", System.Data.SqlDbType.Date).Value = datacadastro.ToString();
            comandos.Parameters.Add("obs", System.Data.SqlDbType.VarChar).Value = observacoes;
            try
            {
                comandos.ExecuteNonQuery();
                return true; 
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
