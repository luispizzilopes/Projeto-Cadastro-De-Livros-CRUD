using MeusLivrosCRUD.Model.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Model.Login
{
    internal class ModelLogin
    {
        ConexaoBd conexao = new ConexaoBd();
        
        public bool Acessar(string usuario, string senha)
        {
            conexao.StrComando = "select * from TabelaLogin where usuario = @usuario and senha = @senha"; 
            SqlCommand comandos = new SqlCommand(conexao.StrComando, conexao.Conectar());
            comandos.Parameters.Add("usuario", System.Data.SqlDbType.VarChar, 50).Value = usuario;
            comandos.Parameters.Add("senha", System.Data.SqlDbType.VarChar, 50).Value = senha;
            SqlDataReader dataReader = comandos.ExecuteReader();
            try
            {
                if(dataReader.HasRows == true)
                {
                    return true; 
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException) 
            {
                return false;
            }
            finally { conexao.Desconectar(); }
        }

        public bool VerificarUsuario(string usuario)
        {
            conexao.StrComando = "select * from TabelaLogin where usuario = @usuario";
            SqlCommand comandos = new SqlCommand(conexao.StrComando, conexao.Conectar());
            comandos.Parameters.Add("usuario", System.Data.SqlDbType.VarChar, 50).Value = usuario;
            SqlDataReader dataReader = comandos.ExecuteReader();
            try
            {
                if (dataReader.HasRows == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return true;
            }
            finally { conexao.Desconectar();}
        }

        public bool Cadastrar(string usuario, string senha)
        {
            if(VerificarUsuario(usuario) == false)
            {
                conexao.StrComando = "insert into TabelaLogin values (@usuario, @senha)";
                SqlCommand comandos = new SqlCommand(conexao.StrComando, conexao.Conectar());
                comandos.Parameters.Add("usuario", System.Data.SqlDbType.VarChar, 50).Value = usuario;
                comandos.Parameters.Add("senha", System.Data.SqlDbType.VarChar, 50).Value = senha;
                try
                {
                    comandos.ExecuteNonQuery();
                    return true; 
                }
                catch (SqlException)
                {
                    return false;
                }
                finally { conexao.Desconectar();}
            }
            else
            {
                return false; 
            }
        }
    }
}
