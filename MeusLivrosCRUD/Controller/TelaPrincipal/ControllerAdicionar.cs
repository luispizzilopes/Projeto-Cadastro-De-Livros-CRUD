using MeusLivrosCRUD.Model.TelaPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivrosCRUD.Controller.TelaPrincipal
{
    internal class ControllerAdicionar
    {
        ModelAdicionar ModelAdicionar = new ModelAdicionar();
        
        public bool AdicionarLivro(string nome, DateTime datalancamento, string nomeautor, string editora, DateTime datacadastro, string observacoes)
        {
            if(ModelAdicionar.AdicionarLivro(nome, datalancamento, nomeautor, editora, datacadastro, observacoes) == true)
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
