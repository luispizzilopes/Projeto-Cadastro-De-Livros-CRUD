using MeusLivrosCRUD.Model.TelaPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Controller.TelaPrincipal
{
    internal class ControllerBuscar
    {
        public string[] Pesquisar(string nome)
        {
            ModelBuscar modelBuscar = new ModelBuscar();
            if(modelBuscar.Pesquisar(nome) != null)
            {
                return modelBuscar.Pesquisar(nome);
            }
            else
            {
                return null; 
            }
        }
    }
}
