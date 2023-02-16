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

        public void DesbloquearCampos()
        {
            txtBoxNomelivro.Enabled = true;
            txtBoxObs.Enabled = true;
            txtBoxNomeAutor.Enabled = true;
            txtBoxEditora.Enabled = true;
            txtBoxDataCadastro.Enabled = true;
            txtBoxData.Enabled = true;
        }

        public void BloquearCampos()
        {
            txtBoxNomelivro.Enabled = false;
            txtBoxObs.Enabled = false;
            txtBoxNomeAutor.Enabled = false;
            txtBoxEditora.Enabled = false;
            txtBoxDataCadastro.Enabled = false;
            txtBoxData.Enabled = false;
        }

        public void LimparCampos()
        {
            txtBoxNomelivro.Text = "";
            txtBoxObs.Text = "";
            txtBoxNomeAutor.Text = "";
            txtBoxEditora.Text = "";
            txtBoxDataCadastro.Text = "";
            txtBoxData.Text = "";
            txtBoxBuscar.Text = ""; 
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DesbloquearCampos();
            LimparCampos();

            btnAdicionar.Enabled = true;
            btnNovo.Enabled = false; 
            btnEditar.Enabled = false;
            btnBuscar.Enabled= false;
            btnExcluir.Enabled = false;
            txtBoxBuscar.Enabled = false; 
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

                    BloquearCampos(); 
                    LimparCampos();
                    btnAdicionar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnNovo.Enabled = true;
                    txtBoxBuscar.Enabled = true; 
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para cadastrar um novo livro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ControllerBuscar controllerBuscar = new ControllerBuscar();
            if(controllerBuscar.Pesquisar(txtBoxBuscar.Text) != null)
            {
                MessageBox.Show("Carregando as informações!", "Carregando...", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                string[] campos = controllerBuscar.Pesquisar(txtBoxBuscar.Text);

                txtBoxNomelivro.Text = campos[0];
                txtBoxData.Text = campos[1];
                txtBoxNomeAutor.Text = campos[2];
                txtBoxEditora.Text = campos[3];
                txtBoxDataCadastro.Text = campos[4];
                txtBoxObs.Text = campos[5];
                DesbloquearCampos();
                btnEditar.Enabled = true; 
                btnExcluir.Enabled = true;
                btnAdicionar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não existe um livro cadastrado com esse nome!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ControllerEditar controllerEditar = new ControllerEditar();
            if (txtBoxNomelivro.Text != string.Empty && txtBoxData.Text != string.Empty && txtBoxDataCadastro.Text != string.Empty &&
                txtBoxEditora.Text != string.Empty && txtBoxNomeAutor.Text != string.Empty && txtBoxObs.Text != string.Empty)
            {
                if (controllerEditar.EditarRegistro(txtBoxBuscar.Text, txtBoxNomelivro.Text, DateTime.Parse(txtBoxData.Text), txtBoxNomeAutor.Text,
                    txtBoxEditora.Text, DateTime.Parse(txtBoxDataCadastro.Text), txtBoxObs.Text) == true)
                {
                    MessageBox.Show("Alteração realizada com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    LimparCampos();
                    BloquearCampos(); 
                }
                else
                {
                    MessageBox.Show("Não foi possível editar!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para cadastrar um novo livro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ControllerExcluir controllerExcluir = new ControllerExcluir();
            
            if(txtBoxBuscar.Text != string.Empty)
            {
                if(controllerExcluir.ExcluirRegistro(txtBoxBuscar.Text) == true)
                {
                    MessageBox.Show("Registro excluido com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    BloquearCampos();
                    btnExcluir.Enabled = false; 
                    btnEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Não existe um livro cadastrado com esse nome!");
                }
            }
        }
        private void lblFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
