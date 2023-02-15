using MeusLivrosCRUD.Model.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Model.TelaPrincipal
{ 
    internal class ModelExcluir
    {
        ConexaoBd conexao = new ConexaoBd();

        public bool ExcluirRegistro(string nome)
        {
            conexao.StrComando = "delete from TabelaLivros where nome = @nome";
            SqlCommand comandos = new SqlCommand(conexao.StrComando, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
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