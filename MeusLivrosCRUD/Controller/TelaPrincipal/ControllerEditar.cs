using MeusLivrosCRUD.Model.TelaPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Controller.TelaPrincipal
{
    internal class ControllerEditar
    {
        ModelEditar modelEditar = new ModelEditar();

        public bool EditarRegistro(string busca, string nome, DateTime datalancamento, string nomeautor, string editora, DateTime datacadastro, string observacoes)
        {
            if(modelEditar.EditarRegistro(busca,nome, datalancamento, nomeautor, editora, datacadastro, observacoes) == true)
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
