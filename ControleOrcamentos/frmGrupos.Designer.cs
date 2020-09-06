namespace ControleOrcamentos
{
    partial class frmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupos));
            this.tabPadrao = new System.Windows.Forms.TabControl();
            this.tabPesquisar = new System.Windows.Forms.TabPage();
            this.dataGridViewPesquisar = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
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
            // tabPadrao
            // 
            this.tabPadrao.Controls.Add(this.tabPesquisar);
            this.tabPadrao.Controls.Add(this.tabPrincipal);
            this.tabPadrao.Location = new System.Drawing.Point(2, 2);
            this.tabPadrao.Name = "tabPadrao";
            this.tabPadrao.SelectedIndex = 0;
            this.tabPadrao.Size = new System.Drawing.Size(802, 301);
            this.tabPadrao.TabIndex = 61;
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
            this.ColumnNome});
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
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 530;
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
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.chkAtivo);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Controls.Add(this.txtDescricao);
            this.tabPrincipal.Controls.Add(this.lblDescricao);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(794, 275);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 5);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Código";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(7, 70);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(781, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 24;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(640, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 23);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(559, 309);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(74, 23);
            this.btnGravar.TabIndex = 58;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(478, 309);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(74, 23);
            this.btnExcluir.TabIndex = 57;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(397, 309);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(74, 23);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(317, 309);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(74, 23);
            this.btnIncluir.TabIndex = 55;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(726, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 60;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 338);
            this.Controls.Add(this.tabPadrao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Name = "frmGrupos";
            this.Text = "Cadastro de Grupos";
            this.tabPadrao.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPadrao;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
    }
}