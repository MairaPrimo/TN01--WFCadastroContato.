namespace TN01__WFCadastroContato
{
    partial class C
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            lblEmail = new Label();
            lblDDDTelefone = new Label();
            lblSobrenome = new Label();
            txtSobrenome = new TextBox();
            gbxTipoTelefone = new GroupBox();
            RdbPessoal = new RadioButton();
            RdbComercial = new RadioButton();
            RdbRecado = new RadioButton();
            txtEmail = new TextBox();
            mkdTelefone = new MaskedTextBox();
            btnVoltar = new Button();
            btnSair = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(64, 34);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(12, 71);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(228, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(64, 316);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            lblEmail.Click += label1_Click;
            // 
            // lblDDDTelefone
            // 
            lblDDDTelefone.AutoSize = true;
            lblDDDTelefone.Location = new Point(64, 175);
            lblDDDTelefone.Name = "lblDDDTelefone";
            lblDDDTelefone.Size = new Size(80, 15);
            lblDDDTelefone.TabIndex = 7;
            lblDDDTelefone.Text = "DDD/Telefone";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(400, 34);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(68, 15);
            lblSobrenome.TabIndex = 8;
            lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(319, 71);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(235, 23);
            txtSobrenome.TabIndex = 9;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(RdbRecado);
            gbxTipoTelefone.Controls.Add(RdbComercial);
            gbxTipoTelefone.Controls.Add(RdbPessoal);
            gbxTipoTelefone.Location = new Point(369, 175);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(368, 92);
            gbxTipoTelefone.TabIndex = 11;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo de Telefone";
            // 
            // RdbPessoal
            // 
            RdbPessoal.AutoSize = true;
            RdbPessoal.Location = new Point(31, 47);
            RdbPessoal.Name = "RdbPessoal";
            RdbPessoal.Size = new Size(64, 19);
            RdbPessoal.TabIndex = 0;
            RdbPessoal.TabStop = true;
            RdbPessoal.Text = "Pessoal";
            RdbPessoal.UseVisualStyleBackColor = true;
            // 
            // RdbComercial
            // 
            RdbComercial.AutoSize = true;
            RdbComercial.Location = new Point(152, 47);
            RdbComercial.Name = "RdbComercial";
            RdbComercial.Size = new Size(79, 19);
            RdbComercial.TabIndex = 1;
            RdbComercial.TabStop = true;
            RdbComercial.Text = "Comercial";
            RdbComercial.UseVisualStyleBackColor = true;
            // 
            // RdbRecado
            // 
            RdbRecado.AutoSize = true;
            RdbRecado.Location = new Point(271, 47);
            RdbRecado.Name = "RdbRecado";
            RdbRecado.Size = new Size(64, 19);
            RdbRecado.TabIndex = 2;
            RdbRecado.TabStop = true;
            RdbRecado.Text = "Recado";
            RdbRecado.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 363);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 23);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(26, 222);
            mkdTelefone.Mask = "(99) 000-000000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(170, 23);
            mkdTelefone.TabIndex = 13;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(441, 332);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(113, 82);
            btnVoltar.TabIndex = 14;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSair
            // 
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.Location = new Point(640, 332);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(97, 82);
            btnSair.TabIndex = 15;
            btnSair.Text = "Salvar";
            btnSair.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnSair);
            Controls.Add(mkdTelefone);
            Controls.Add(txtEmail);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobrenome);
            Controls.Add(lblDDDTelefone);
            Controls.Add(lblEmail);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Name = "C";
            Text = "Cadastrar Contrato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Label lblEmail;
        private Label lblDDDTelefone;
        private Label lblSobrenome;
        private TextBox txtSobrenome;
        private GroupBox gbxTipoTelefone;
        private RadioButton RdbRecado;
        private RadioButton RdbComercial;
        private RadioButton RdbPessoal;
        private TextBox txtEmail;
        private MaskedTextBox mkdTelefone;
        private Button btnVoltar;
        private Button btnSair;
    }
}
