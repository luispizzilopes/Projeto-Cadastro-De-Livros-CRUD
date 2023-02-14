using System.Data.SqlClient;

namespace MeusLivrosCRUD.Model.DAL
{
    internal class ConexaoBd
    {
        SqlConnection conexao = new SqlConnection();
        private string StrSql = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BdMeusLivros;Data Source=DESKTOP-CK95DQO\SQLEXPRESS01";
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
