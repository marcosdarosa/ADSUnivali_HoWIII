namespace ControleOrcamentos
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblFoneFixo = new System.Windows.Forms.Label();
            this.lblFoneCelular = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairo = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.mtxtFoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.tabPadrao = new System.Windows.Forms.TabControl();
            this.tabPesquisar = new System.Windows.Forms.TabPage();
            this.dataGridViewPesquisar = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFoneFixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.tabPadrao.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(731, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(322, 314);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(74, 23);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(402, 314);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(74, 23);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(483, 314);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(564, 314);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(74, 23);
            this.btnGravar.TabIndex = 19;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(645, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(85, 23);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 1;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(7, 70);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(442, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(115, 162);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(452, 20);
            this.txtLogradouro.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(573, 162);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(49, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(9, 209);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(230, 20);
            this.txtBairro.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(248, 209);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(493, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(747, 209);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(37, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(628, 162);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(158, 20);
            this.txtComplemento.TabIndex = 11;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 5);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(6, 103);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 13);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "C.P.F.";
            // 
            // lblFoneFixo
            // 
            this.lblFoneFixo.AutoSize = true;
            this.lblFoneFixo.Location = new System.Drawing.Point(241, 103);
            this.lblFoneFixo.Name = "lblFoneFixo";
            this.lblFoneFixo.Size = new System.Drawing.Size(71, 13);
            this.lblFoneFixo.TabIndex = 26;
            this.lblFoneFixo.Text = "Telefone Fixo";
            // 
            // lblFoneCelular
            // 
            this.lblFoneCelular.AutoSize = true;
            this.lblFoneCelular.Location = new System.Drawing.Point(347, 103);
            this.lblFoneCelular.Name = "lblFoneCelular";
            this.lblFoneCelular.Size = new System.Drawing.Size(39, 13);
            this.lblFoneCelular.TabIndex = 28;
            this.lblFoneCelular.Text = "Celular";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(6, 146);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(37, 13);
            this.lblCep.TabIndex = 29;
            this.lblCep.Text = "C.E.P.";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(112, 146);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 30;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(575, 146);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 31;
            this.lblNumero.Text = "Nº";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(625, 146);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(71, 13);
            this.lblComplemento.TabIndex = 32;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblBairo
            // 
            this.lblBairo.AutoSize = true;
            this.lblBairo.Location = new System.Drawing.Point(9, 193);
            this.lblBairo.Name = "lblBairo";
            this.lblBairo.Size = new System.Drawing.Size(34, 13);
            this.lblBairo.TabIndex = 33;
            this.lblBairo.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(245, 193);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 34;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(744, 193);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(124, 103);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(29, 13);
            this.lblRg.TabIndex = 37;
            this.lblRg.Text = "R.G.";
            // 
            // txtRg
            // 
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Enabled = false;
            this.txtRg.Location = new System.Drawing.Point(127, 119);
            this.txtRg.MaxLength = 15;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(112, 20);
            this.txtRg.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(452, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(455, 119);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(714, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(74, 23);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // mtxtFoneFixo
            // 
            this.mtxtFoneFixo.Enabled = false;
            this.mtxtFoneFixo.Location = new System.Drawing.Point(244, 119);
            this.mtxtFoneFixo.Mask = "(00)0000-0000";
            this.mtxtFoneFixo.Name = "mtxtFoneFixo";
            this.mtxtFoneFixo.Size = new System.Drawing.Size(100, 20);
            this.mtxtFoneFixo.TabIndex = 5;
            // 
            // mtxtFoneCelular
            // 
            this.mtxtFoneCelular.Enabled = false;
            this.mtxtFoneCelular.Location = new System.Drawing.Point(350, 119);
            this.mtxtFoneCelular.Mask = "(00)00000-0000";
            this.mtxtFoneCelular.Name = "mtxtFoneCelular";
            this.mtxtFoneCelular.Size = new System.Drawing.Size(100, 20);
            this.mtxtFoneCelular.TabIndex = 6;
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Enabled = false;
            this.mtxtCpf.Location = new System.Drawing.Point(7, 119);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(112, 20);
            this.mtxtCpf.TabIndex = 3;
            // 
            // mtxtCep
            // 
            this.mtxtCep.Enabled = false;
            this.mtxtCep.Location = new System.Drawing.Point(7, 162);
            this.mtxtCep.Mask = "00,000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(100, 20);
            this.mtxtCep.TabIndex = 8;
            // 
            // tabPadrao
            // 
            this.tabPadrao.Controls.Add(this.tabPesquisar);
            this.tabPadrao.Controls.Add(this.tabPrincipal);
            this.tabPadrao.Location = new System.Drawing.Point(7, 7);
            this.tabPadrao.Name = "tabPadrao";
            this.tabPadrao.SelectedIndex = 0;
            this.tabPadrao.Size = new System.Drawing.Size(802, 301);
            this.tabPadrao.TabIndex = 40;
            this.tabPadrao.SelectedIndexChanged += new System.EventHandler(this.tabPadrao_SelectedIndexChanged);
            // 
            // tabPesquisar
            // 
            this.tabPesquisar.Controls.Add(this.dataGridViewPesquisar);
            this.tabPesquisar.Controls.Add(this.txtPesquisar);
            this.tabPesquisar.Controls.Add(this.btnPesquisar);
            this.tabPesquisar.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisar.Name = "tabPesquisar";
            this.tabPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisar.Size = new System.Drawing.Size(794, 275);
            this.tabPesquisar.TabIndex = 0;
            this.tabPesquisar.Text = "Pesquisar";
            this.tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPesquisar
            // 
            this.dataGridViewPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnAtivo,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnRG,
            this.ColumnFoneFixo,
            this.ColumnFoneCelular,
            this.ColumnEmail,
            this.ColumnCEP,
            this.ColumnLogradouro,
            this.ColumnNumero,
            this.ColumnComplemento,
            this.ColumnBairro,
            this.ColumnCidade,
            this.ColumnEstado});
            this.dataGridViewPesquisar.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            this.dataGridViewPesquisar.ReadOnly = true;
            this.dataGridViewPesquisar.Size = new System.Drawing.Size(784, 229);
            this.dataGridViewPesquisar.TabIndex = 17;
            this.dataGridViewPesquisar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesquisar_CellContentClick);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnAtivo
            // 
            this.ColumnAtivo.HeaderText = "Ativo";
            this.ColumnAtivo.Name = "ColumnAtivo";
            this.ColumnAtivo.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 530;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.HeaderText = "C.P.F.";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            // 
            // ColumnRG
            // 
            this.ColumnRG.HeaderText = "R.G.";
            this.ColumnRG.Name = "ColumnRG";
            this.ColumnRG.ReadOnly = true;
            // 
            // ColumnFoneFixo
            // 
            this.ColumnFoneFixo.HeaderText = "Telefone Fixo";
            this.ColumnFoneFixo.Name = "ColumnFoneFixo";
            this.ColumnFoneFixo.ReadOnly = true;
            // 
            // ColumnFoneCelular
            // 
            this.ColumnFoneCelular.HeaderText = "Celular";
            this.ColumnFoneCelular.Name = "ColumnFoneCelular";
            this.ColumnFoneCelular.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnCEP
            // 
            this.ColumnCEP.HeaderText = "C.E.P.";
            this.ColumnCEP.Name = "ColumnCEP";
            this.ColumnCEP.ReadOnly = true;
            // 
            // ColumnLogradouro
            // 
            this.ColumnLogradouro.HeaderText = "Logradouro";
            this.ColumnLogradouro.Name = "ColumnLogradouro";
            this.ColumnLogradouro.ReadOnly = true;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Nº";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.ReadOnly = true;
            // 
            // ColumnComplemento
            // 
            this.ColumnComplemento.HeaderText = "Complemento";
            this.ColumnComplemento.Name = "ColumnComplemento";
            this.ColumnComplemento.ReadOnly = true;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.HeaderText = "Bairro";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.ReadOnly = true;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(6, 9);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(702, 20);
            this.txtPesquisar.TabIndex = 16;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.mtxtCep);
            this.tabPrincipal.Controls.Add(this.chkAtivo);
            this.tabPrincipal.Controls.Add(this.mtxtCpf);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Controls.Add(this.mtxtFoneCelular);
            this.tabPrincipal.Controls.Add(this.txtEmail);
            this.tabPrincipal.Controls.Add(this.mtxtFoneFixo);
            this.tabPrincipal.Controls.Add(this.txtNome);
            this.tabPrincipal.Controls.Add(this.txtLogradouro);
            this.tabPrincipal.Controls.Add(this.lblEmail);
            this.tabPrincipal.Controls.Add(this.txtNumero);
            this.tabPrincipal.Controls.Add(this.txtBairro);
            this.tabPrincipal.Controls.Add(this.lblRg);
            this.tabPrincipal.Controls.Add(this.txtCidade);
            this.tabPrincipal.Controls.Add(this.txtRg);
            this.tabPrincipal.Controls.Add(this.txtEstado);
            this.tabPrincipal.Controls.Add(this.lblEstado);
            this.tabPrincipal.Controls.Add(this.txtComplemento);
            this.tabPrincipal.Controls.Add(this.lblCidade);
            this.tabPrincipal.Controls.Add(this.lblNome);
            this.tabPrincipal.Controls.Add(this.lblBairo);
            this.tabPrincipal.Controls.Add(this.lblCpf);
            this.tabPrincipal.Controls.Add(this.lblComplemento);
            this.tabPrincipal.Controls.Add(this.lblFoneFixo);
            this.tabPrincipal.Controls.Add(this.lblNumero);
            this.tabPrincipal.Controls.Add(this.lblFoneCelular);
            this.tabPrincipal.Controls.Add(this.lblLogradouro);
            this.tabPrincipal.Controls.Add(this.lblCep);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(794, 275);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 345);
            this.Controls.Add(this.tabPadrao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Name = "frmClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.tabPadrao.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblFoneFixo;
        private System.Windows.Forms.Label lblFoneCelular;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairo;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox mtxtFoneFixo;
        private System.Windows.Forms.MaskedTextBox mtxtFoneCelular;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.TabControl tabPadrao;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.DataGridView dataGridViewPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFoneFixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFoneCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
    }
}