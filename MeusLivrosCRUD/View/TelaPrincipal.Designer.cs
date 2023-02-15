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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNomelivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxData = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNomeAutor = new System.Windows.Forms.TextBox();
            this.txtBoxEditora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxObs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(52, 37);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 29);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(164, 37);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(106, 29);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(277, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(389, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 29);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(502, 37);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(106, 29);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar nome do livro:";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(228, 93);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(414, 26);
            this.txtBoxBuscar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do livro:";
            // 
            // txtBoxNomelivro
            // 
            this.txtBoxNomelivro.Enabled = false;
            this.txtBoxNomelivro.Location = new System.Drawing.Point(158, 137);
            this.txtBoxNomelivro.Name = "txtBoxNomelivro";
            this.txtBoxNomelivro.Size = new System.Drawing.Size(483, 26);
            this.txtBoxNomelivro.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data lançamento:";
            // 
            // txtBoxData
            // 
            this.txtBoxData.Enabled = false;
            this.txtBoxData.Location = new System.Drawing.Point(172, 182);
            this.txtBoxData.Mask = "00/00/0000";
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(140, 26);
            this.txtBoxData.TabIndex = 10;
            this.txtBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome autor:";
            // 
            // txtBoxNomeAutor
            // 
            this.txtBoxNomeAutor.Enabled = false;
            this.txtBoxNomeAutor.Location = new System.Drawing.Point(430, 182);
            this.txtBoxNomeAutor.Name = "txtBoxNomeAutor";
            this.txtBoxNomeAutor.Size = new System.Drawing.Size(211, 26);
            this.txtBoxNomeAutor.TabIndex = 12;
            // 
            // txtBoxEditora
            // 
            this.txtBoxEditora.Enabled = false;
            this.txtBoxEditora.Location = new System.Drawing.Point(104, 227);
            this.txtBoxEditora.Name = "txtBoxEditora";
            this.txtBoxEditora.Size = new System.Drawing.Size(260, 26);
            this.txtBoxEditora.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Editora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data cadastro: ";
            // 
            // txtBoxDataCadastro
            // 
            this.txtBoxDataCadastro.Enabled = false;
            this.txtBoxDataCadastro.Location = new System.Drawing.Point(501, 227);
            this.txtBoxDataCadastro.Mask = "00/00/0000";
            this.txtBoxDataCadastro.Name = "txtBoxDataCadastro";
            this.txtBoxDataCadastro.Size = new System.Drawing.Size(140, 26);
            this.txtBoxDataCadastro.TabIndex = 16;
            this.txtBoxDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Observação:";
            // 
            // txtBoxObs
            // 
            this.txtBoxObs.Enabled = false;
            this.txtBoxObs.Location = new System.Drawing.Point(30, 297);
            this.txtBoxObs.Multiline = true;
            this.txtBoxObs.Name = "txtBoxObs";
            this.txtBoxObs.Size = new System.Drawing.Size(612, 115);
            this.txtBoxObs.TabIndex = 18;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 437);
            this.Controls.Add(this.txtBoxObs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxDataCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEditora);
            this.Controls.Add(this.txtBoxNomeAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNomelivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnNovo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
        private Label label1;
        private TextBox txtBoxBuscar;
        private Label label2;
        private TextBox txtBoxNomelivro;
        private Label label3;
        private MaskedTextBox txtBoxData;
        private Label label4;
        private TextBox txtBoxNomeAutor;
        private TextBox txtBoxEditora;
        private Label label5;
        private Label label6;
        private MaskedTextBox txtBoxDataCadastro;
        private Label label7;
        private TextBox txtBoxObs;
    }
}