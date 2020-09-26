namespace ControleOrcamentos
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.tabPadrao = new System.Windows.Forms.TabControl();
            this.tabPesquisar = new System.Windows.Forms.TabPage();
            this.dataGridViewPesquisar = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAplicacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtAplicacao = new System.Windows.Forms.TextBox();
            this.lblAplicacao = new System.Windows.Forms.Label();
            this.lblUn = new System.Windows.Forms.Label();
            this.txtUn = new System.Windows.Forms.TextBox();
            this.lblCodBar = new System.Windows.Forms.Label();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.mtxtQtdEstoque = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mtxtPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDecricao = new System.Windows.Forms.Label();
            this.lblQtdEstoque = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabPadrao.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).BeginInit();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrupos
            // 
            this.btnGrupos.Location = new System.Drawing.Point(87, 310);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(74, 23);
            this.btnGrupos.TabIndex = 5;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.UseVisualStyleBackColor = true;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(7, 310);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(74, 23);
            this.btnMarcas.TabIndex = 4;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // tabPadrao
            // 
            this.tabPadrao.Controls.Add(this.tabPesquisar);
            this.tabPadrao.Controls.Add(this.tabPrincipal);
            this.tabPadrao.Location = new System.Drawing.Point(3, 3);
            this.tabPadrao.Name = "tabPadrao";
            this.tabPadrao.SelectedIndex = 0;
            this.tabPadrao.Size = new System.Drawing.Size(802, 301);
            this.tabPadrao.TabIndex = 47;
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
            this.ColumnDescricao,
            this.ColumnCodBar,
            this.ColumnUN,
            this.ColumnAplicacao,
            this.ColumnMarca,
            this.ColumnGrupo,
            this.ColumnQtdEstoque,
            this.ColumnPrecoVenda});
            this.dataGridViewPesquisar.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            this.dataGridViewPesquisar.ReadOnly = true;
            this.dataGridViewPesquisar.Size = new System.Drawing.Size(784, 229);
            this.dataGridViewPesquisar.TabIndex = 17;
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
            // ColumnDescricao
            // 
            this.ColumnDescricao.HeaderText = "Descrição";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.ReadOnly = true;
            this.ColumnDescricao.Width = 530;
            // 
            // ColumnCodBar
            // 
            this.ColumnCodBar.HeaderText = "Código de Barras";
            this.ColumnCodBar.Name = "ColumnCodBar";
            this.ColumnCodBar.ReadOnly = true;
            // 
            // ColumnUN
            // 
            this.ColumnUN.HeaderText = "UN";
            this.ColumnUN.Name = "ColumnUN";
            this.ColumnUN.ReadOnly = true;
            // 
            // ColumnAplicacao
            // 
            this.ColumnAplicacao.HeaderText = "Aplicação";
            this.ColumnAplicacao.Name = "ColumnAplicacao";
            this.ColumnAplicacao.ReadOnly = true;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            // 
            // ColumnGrupo
            // 
            this.ColumnGrupo.HeaderText = "Grupo";
            this.ColumnGrupo.Name = "ColumnGrupo";
            this.ColumnGrupo.ReadOnly = true;
            // 
            // ColumnQtdEstoque
            // 
            this.ColumnQtdEstoque.HeaderText = "Qtd em Estoque";
            this.ColumnQtdEstoque.Name = "ColumnQtdEstoque";
            this.ColumnQtdEstoque.ReadOnly = true;
            // 
            // ColumnPrecoVenda
            // 
            this.ColumnPrecoVenda.HeaderText = "Preço de Venda";
            this.ColumnPrecoVenda.Name = "ColumnPrecoVenda";
            this.ColumnPrecoVenda.ReadOnly = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(6, 9);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(702, 20);
            this.txtPesquisar.TabIndex = 16;
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
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.lblGrupo);
            this.tabPrincipal.Controls.Add(this.lblMarca);
            this.tabPrincipal.Controls.Add(this.cmbGrupo);
            this.tabPrincipal.Controls.Add(this.cmbMarca);
            this.tabPrincipal.Controls.Add(this.txtAplicacao);
            this.tabPrincipal.Controls.Add(this.lblAplicacao);
            this.tabPrincipal.Controls.Add(this.lblUn);
            this.tabPrincipal.Controls.Add(this.txtUn);
            this.tabPrincipal.Controls.Add(this.lblCodBar);
            this.tabPrincipal.Controls.Add(this.txtCodBar);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.chkAtivo);
            this.tabPrincipal.Controls.Add(this.mtxtQtdEstoque);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Controls.Add(this.mtxtPrecoVenda);
            this.tabPrincipal.Controls.Add(this.txtDescricao);
            this.tabPrincipal.Controls.Add(this.lblDecricao);
            this.tabPrincipal.Controls.Add(this.lblQtdEstoque);
            this.tabPrincipal.Controls.Add(this.lblPrecoVenda);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(794, 275);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(283, 152);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 40;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(4, 152);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 39;
            this.lblMarca.Text = "Marca";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.Enabled = false;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(286, 168);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(266, 21);
            this.cmbGrupo.TabIndex = 38;
            // 
            // cmbMarca
            // 
            this.cmbMarca.Enabled = false;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(7, 168);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(266, 21);
            this.cmbMarca.TabIndex = 37;
            // 
            // txtAplicacao
            // 
            this.txtAplicacao.Enabled = false;
            this.txtAplicacao.Location = new System.Drawing.Point(7, 117);
            this.txtAplicacao.Name = "txtAplicacao";
            this.txtAplicacao.Size = new System.Drawing.Size(781, 20);
            this.txtAplicacao.TabIndex = 33;
            // 
            // lblAplicacao
            // 
            this.lblAplicacao.AutoSize = true;
            this.lblAplicacao.Location = new System.Drawing.Point(4, 101);
            this.lblAplicacao.Name = "lblAplicacao";
            this.lblAplicacao.Size = new System.Drawing.Size(54, 13);
            this.lblAplicacao.TabIndex = 36;
            this.lblAplicacao.Text = "Aplicação";
            // 
            // lblUn
            // 
            this.lblUn.AutoSize = true;
            this.lblUn.Location = new System.Drawing.Point(762, 55);
            this.lblUn.Name = "lblUn";
            this.lblUn.Size = new System.Drawing.Size(23, 13);
            this.lblUn.TabIndex = 35;
            this.lblUn.Text = "UN";
            this.lblUn.Click += new System.EventHandler(this.lblUn_Click);
            // 
            // txtUn
            // 
            this.txtUn.Enabled = false;
            this.txtUn.Location = new System.Drawing.Point(757, 70);
            this.txtUn.MaxLength = 2;
            this.txtUn.Name = "txtUn";
            this.txtUn.Size = new System.Drawing.Size(31, 20);
            this.txtUn.TabIndex = 31;
            // 
            // lblCodBar
            // 
            this.lblCodBar.AutoSize = true;
            this.lblCodBar.Location = new System.Drawing.Point(598, 55);
            this.lblCodBar.Name = "lblCodBar";
            this.lblCodBar.Size = new System.Drawing.Size(88, 13);
            this.lblCodBar.TabIndex = 32;
            this.lblCodBar.Text = "Código de Barras";
            // 
            // txtCodBar
            // 
            this.txtCodBar.Enabled = false;
            this.txtCodBar.Location = new System.Drawing.Point(601, 70);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(150, 20);
            this.txtCodBar.TabIndex = 29;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 20);
            this.txtCodigo.TabIndex = 0;
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
            // mtxtQtdEstoque
            // 
            this.mtxtQtdEstoque.Enabled = false;
            this.mtxtQtdEstoque.Location = new System.Drawing.Point(566, 169);
            this.mtxtQtdEstoque.Mask = "999.999,99";
            this.mtxtQtdEstoque.Name = "mtxtQtdEstoque";
            this.mtxtQtdEstoque.Size = new System.Drawing.Size(112, 20);
            this.mtxtQtdEstoque.TabIndex = 3;
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
            // mtxtPrecoVenda
            // 
            this.mtxtPrecoVenda.Enabled = false;
            this.mtxtPrecoVenda.Location = new System.Drawing.Point(688, 169);
            this.mtxtPrecoVenda.Mask = "999.999,99";
            this.mtxtPrecoVenda.Name = "mtxtPrecoVenda";
            this.mtxtPrecoVenda.Size = new System.Drawing.Size(100, 20);
            this.mtxtPrecoVenda.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(7, 70);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(588, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDecricao
            // 
            this.lblDecricao.AutoSize = true;
            this.lblDecricao.Location = new System.Drawing.Point(4, 54);
            this.lblDecricao.Name = "lblDecricao";
            this.lblDecricao.Size = new System.Drawing.Size(55, 13);
            this.lblDecricao.TabIndex = 24;
            this.lblDecricao.Text = "Descrição";
            // 
            // lblQtdEstoque
            // 
            this.lblQtdEstoque.AutoSize = true;
            this.lblQtdEstoque.Location = new System.Drawing.Point(565, 153);
            this.lblQtdEstoque.Name = "lblQtdEstoque";
            this.lblQtdEstoque.Size = new System.Drawing.Size(104, 13);
            this.lblQtdEstoque.TabIndex = 25;
            this.lblQtdEstoque.Text = "Quantidade Estoque";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(685, 153);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoVenda.TabIndex = 28;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(641, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(560, 310);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(74, 23);
            this.btnGravar.TabIndex = 44;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(479, 310);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(398, 310);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(74, 23);
            this.btnAlterar.TabIndex = 42;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(318, 310);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(74, 23);
            this.btnIncluir.TabIndex = 41;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(727, 310);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 340);
            this.Controls.Add(this.tabPadrao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGrupos);
            this.Controls.Add(this.btnMarcas);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.tabPadrao.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrupos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.TabControl tabPadrao;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.MaskedTextBox mtxtQtdEstoque;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox mtxtPrecoVenda;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDecricao;
        private System.Windows.Forms.Label lblQtdEstoque;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtAplicacao;
        private System.Windows.Forms.Label lblAplicacao;
        private System.Windows.Forms.Label lblUn;
        private System.Windows.Forms.TextBox txtUn;
        private System.Windows.Forms.Label lblCodBar;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAplicacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecoVenda;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}