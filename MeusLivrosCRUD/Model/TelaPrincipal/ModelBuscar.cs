using MeusLivrosCRUD.Model.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Model.TelaPrincipal
{
    internal class ModelBuscar
    {
        ConexaoBd conexao = new ConexaoBd();

        public string[] Pesquisar(string nome)
        {
            string StrComando = "select * from TabelaLivros where nome = @nome";
            SqlCommand comando = new SqlCommand(StrComando, conexao.Conectar());
            comando.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
            
            try
            {
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    if (dataReader.HasRows == true)
                    {
                        dataReader.Read();
                        string[] campos = new string[6];
                        campos[0] = Convert.ToString(dataReader["nome"]);
                        campos[1] = Convert.ToString(dataReader["ano"]);
                        campos[2] = Convert.ToString(dataReader["autor"]);
                        campos[3] = Convert.ToString(dataReader["editora"]);
                        campos[4] = Convert.ToString(dataReader["datacadastro"]);
                        campos[5] = Convert.ToString(dataReader["observacoes"]);

                        return campos;
                    }
                    else
                    {
                        return null;
                    }
                }     
            }
            catch (SqlException)
            {
                return null; 
            }
            finally { conexao.Desconectar(); }  
        }
    }
}
