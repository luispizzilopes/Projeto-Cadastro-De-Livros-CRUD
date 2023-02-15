using MeusLivrosCRUD.Model.TelaPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Controller.TelaPrincipal
{
    internal class ControllerExcluir
    {
        ModelExcluir modelExcluir = new ModelExcluir(); 

        public bool ExcluirRegistro(string nome)
        {
            if(modelExcluir.ExcluirRegistro(nome) == true)
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
