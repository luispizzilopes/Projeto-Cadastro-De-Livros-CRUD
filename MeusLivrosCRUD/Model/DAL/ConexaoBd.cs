using System.Data.SqlClient;

namespace MeusLivrosCRUD.Model.DAL
{
    internal class ConexaoBd
    {
        SqlConnection conexao = new SqlConnection();
        private string StrSql = File.ReadAllText("LocalBd.dll");
        public string? StrComando { get; set; }
        public ConexaoBd()
        {
            conexao.ConnectionString = StrSql;
        }
        public SqlConnection Conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }

            return conexao;
        }
        public void Desconectar()
        {
            conexao.Close();
        }
    }
}
