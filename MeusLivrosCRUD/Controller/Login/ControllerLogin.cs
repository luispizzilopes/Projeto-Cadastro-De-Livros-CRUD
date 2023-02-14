using MeusLivrosCRUD.Model.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Controller.Login
{
    internal class ControllerLogin
    {
        ModelLogin modelLogin = new ModelLogin();

        public bool Acessar(string usuario, string senha)
        {
            if(modelLogin.Acessar(usuario, senha) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Cadastrar(string usuario, string senha)
        {
            if(modelLogin.Cadastrar(usuario, senha) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
