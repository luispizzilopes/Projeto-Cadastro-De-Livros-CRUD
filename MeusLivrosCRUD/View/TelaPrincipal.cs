using MeusLivrosCRUD.Controller.TelaPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeusLivrosCRUD.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtBoxNomelivro.Enabled = true;
            txtBoxObs.Enabled = true;
            txtBoxNomeAutor.Enabled = true;
            txtBoxEditora.Enabled = true;   
            txtBoxDataCadastro.Enabled = true;  
            txtBoxData.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(txtBoxNomelivro.Text != string.Empty && txtBoxData.Text != string.Empty && txtBoxDataCadastro.Text != string.Empty && 
                txtBoxEditora.Text != string.Empty && txtBoxNomeAutor.Text != string.Empty && txtBoxObs.Text != string.Empty)
            {
                ControllerAdicionar controllerAdicionar = new ControllerAdicionar();
                if(controllerAdicionar.AdicionarLivro(txtBoxNomelivro.Text, DateTime.Parse(txtBoxData.Text), txtBoxNomeAutor.Text, 
                    txtBoxEditora.Text, DateTime.Parse(txtBoxDataCadastro.Text), txtBoxObs.Text) == true)
                {
                    MessageBox.Show("Livro cadastrado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
