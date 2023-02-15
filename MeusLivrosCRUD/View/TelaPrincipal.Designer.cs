namespace MeusLivrosCRUD.View
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxNomelivro = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtBoxData = new System.Windows.Forms.MaskedTextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtBoxNomeAutor = new System.Windows.Forms.TextBox();
            this.txtBoxEditora = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtBoxDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtBoxObs = new System.Windows.Forms.TextBox();
            this.lblFechar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(58, 55);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 29);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(170, 55);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(106, 29);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(283, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(395, 55);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 29);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(508, 55);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 29);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(30, 114);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(186, 20);
            this.lblPesquisa.TabIndex = 5;
            this.lblPesquisa.Text = "Pesquisar nome do livro:";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(228, 111);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(414, 26);
            this.txtBoxBuscar.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 158);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(116, 20);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome do livro:";
            // 
            // txtBoxNomelivro
            // 
            this.txtBoxNomelivro.Enabled = false;
            this.txtBoxNomelivro.Location = new System.Drawing.Point(158, 155);
            this.txtBoxNomelivro.Name = "txtBoxNomelivro";
            this.txtBoxNomelivro.Size = new System.Drawing.Size(483, 26);
            this.txtBoxNomelivro.TabIndex = 8;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(30, 203);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(142, 20);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data lançamento:";
            // 
            // txtBoxData
            // 
            this.txtBoxData.Enabled = false;
            this.txtBoxData.Location = new System.Drawing.Point(172, 200);
            this.txtBoxData.Mask = "00/00/0000";
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(140, 26);
            this.txtBoxData.TabIndex = 10;
            this.txtBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(320, 203);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(100, 20);
            this.lblAutor.TabIndex = 11;
            this.lblAutor.Text = "Nome autor:";
            // 
            // txtBoxNomeAutor
            // 
            this.txtBoxNomeAutor.Enabled = false;
            this.txtBoxNomeAutor.Location = new System.Drawing.Point(430, 200);
            this.txtBoxNomeAutor.Name = "txtBoxNomeAutor";
            this.txtBoxNomeAutor.Size = new System.Drawing.Size(211, 26);
            this.txtBoxNomeAutor.TabIndex = 12;
            // 
            // txtBoxEditora
            // 
            this.txtBoxEditora.Enabled = false;
            this.txtBoxEditora.Location = new System.Drawing.Point(104, 245);
            this.txtBoxEditora.Name = "txtBoxEditora";
            this.txtBoxEditora.Size = new System.Drawing.Size(260, 26);
            this.txtBoxEditora.TabIndex = 13;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(30, 248);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(64, 20);
            this.lblEditora.TabIndex = 14;
            this.lblEditora.Text = "Editora:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(372, 248);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(123, 20);
            this.lblDataCadastro.TabIndex = 15;
            this.lblDataCadastro.Text = "Data cadastro: ";
            // 
            // txtBoxDataCadastro
            // 
            this.txtBoxDataCadastro.Enabled = false;
            this.txtBoxDataCadastro.Location = new System.Drawing.Point(501, 245);
            this.txtBoxDataCadastro.Mask = "00/00/0000";
            this.txtBoxDataCadastro.Name = "txtBoxDataCadastro";
            this.txtBoxDataCadastro.Size = new System.Drawing.Size(140, 26);
            this.txtBoxDataCadastro.TabIndex = 16;
            this.txtBoxDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(30, 292);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(107, 20);
            this.lblObs.TabIndex = 17;
            this.lblObs.Text = "Observação:";
            // 
            // txtBoxObs
            // 
            this.txtBoxObs.Enabled = false;
            this.txtBoxObs.Location = new System.Drawing.Point(30, 315);
            this.txtBoxObs.Multiline = true;
            this.txtBoxObs.Name = "txtBoxObs";
            this.txtBoxObs.Size = new System.Drawing.Size(612, 115);
            this.txtBoxObs.TabIndex = 18;
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.lblFechar.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(639, -1);
            this.lblFechar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(32, 34);
            this.lblFechar.TabIndex = 19;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.panel1.Location = new System.Drawing.Point(-6, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 41);
            this.panel1.TabIndex = 20;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 447);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.txtBoxObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtBoxDataCadastro);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.txtBoxEditora);
            this.Controls.Add(this.txtBoxNomeAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtBoxNomelivro);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNovo;
        private Button btnAdicionar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label lblPesquisa;
        private TextBox txtBoxBuscar;
        private Label lblNome;
        private TextBox txtBoxNomelivro;
        private Label lblData;
        private MaskedTextBox txtBoxData;
        private Label lblAutor;
        private TextBox txtBoxNomeAutor;
        private TextBox txtBoxEditora;
        private Label lblEditora;
        private Label lblDataCadastro;
        private MaskedTextBox txtBoxDataCadastro;
        private Label lblObs;
        private TextBox txtBoxObs;
        private Label lblFechar;
        private Panel panel1;
    }
}