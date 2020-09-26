namespace ControleOrcamentos
{
    partial class frmOrcamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamentos));
            this.tabPadrao = new System.Windows.Forms.TabControl();
            this.tabPesquisar = new System.Windows.Forms.TabPage();
            this.dataGridViewPesquisar = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConsultor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.mtxtTotalOrc = new System.Windows.Forms.MaskedTextBox();
            this.lblTotalOrc = new System.Windows.Forms.Label();
            this.mtxtDescontoOrc = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontoOrc = new System.Windows.Forms.Label();
            this.mtxtTotalBrutoOrc = new System.Windows.Forms.MaskedTextBox();
            this.lblTotalBrutoOrc = new System.Windows.Forms.Label();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblUnitario = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.mtxtTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDesconto = new System.Windows.Forms.MaskedTextBox();
            this.mtxtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.mtxtUnitario = new System.Windows.Forms.MaskedTextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.ColumnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVlrUnitarioProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescontoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFormaPgto = new System.Windows.Forms.Label();
            this.txtFormaPgto = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.Consultor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbConsultor = new System.Windows.Forms.ComboBox();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtValidade = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPadrao
            // 
            this.tabPadrao.Controls.Add(this.tabPesquisar);
            this.tabPadrao.Controls.Add(this.tabPrincipal);
            this.tabPadrao.Location = new System.Drawing.Point(12, 12);
            this.tabPadrao.Name = "tabPadrao";
            this.tabPadrao.SelectedIndex = 0;
            this.tabPadrao.Size = new System.Drawing.Size(802, 565);
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
            this.tabPesquisar.Size = new System.Drawing.Size(794, 539);
            this.tabPesquisar.TabIndex = 0;
            this.tabPesquisar.Text = "Pesquisar";
            this.tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPesquisar
            // 
            this.dataGridViewPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesquisar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnCliente,
            this.ColumnConsultor,
            this.ColumnStatus,
            this.ColumnTotal});
            this.dataGridViewPesquisar.Location = new System.Drawing.Point(6, 38);
            this.dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            this.dataGridViewPesquisar.ReadOnly = true;
            this.dataGridViewPesquisar.Size = new System.Drawing.Size(784, 495);
            this.dataGridViewPesquisar.TabIndex = 17;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Width = 200;
            // 
            // ColumnConsultor
            // 
            this.ColumnConsultor.HeaderText = "Consultor";
            this.ColumnConsultor.Name = "ColumnConsultor";
            this.ColumnConsultor.ReadOnly = true;
            this.ColumnConsultor.Width = 200;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 150;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
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
            this.tabPrincipal.Controls.Add(this.mtxtTotalOrc);
            this.tabPrincipal.Controls.Add(this.lblTotalOrc);
            this.tabPrincipal.Controls.Add(this.mtxtDescontoOrc);
            this.tabPrincipal.Controls.Add(this.lblDescontoOrc);
            this.tabPrincipal.Controls.Add(this.mtxtTotalBrutoOrc);
            this.tabPrincipal.Controls.Add(this.lblTotalBrutoOrc);
            this.tabPrincipal.Controls.Add(this.btnExcluirProduto);
            this.tabPrincipal.Controls.Add(this.btnIncluirProduto);
            this.tabPrincipal.Controls.Add(this.lblTotal);
            this.tabPrincipal.Controls.Add(this.lblDesconto);
            this.tabPrincipal.Controls.Add(this.lblUnitario);
            this.tabPrincipal.Controls.Add(this.lblQuantidade);
            this.tabPrincipal.Controls.Add(this.mtxtTotal);
            this.tabPrincipal.Controls.Add(this.mtxtDesconto);
            this.tabPrincipal.Controls.Add(this.mtxtQuantidade);
            this.tabPrincipal.Controls.Add(this.mtxtUnitario);
            this.tabPrincipal.Controls.Add(this.cmbProduto);
            this.tabPrincipal.Controls.Add(this.lblProduto);
            this.tabPrincipal.Controls.Add(this.dataGridViewProdutos);
            this.tabPrincipal.Controls.Add(this.lblFormaPgto);
            this.tabPrincipal.Controls.Add(this.txtFormaPgto);
            this.tabPrincipal.Controls.Add(this.lblCliente);
            this.tabPrincipal.Controls.Add(this.Consultor);
            this.tabPrincipal.Controls.Add(this.lblStatus);
            this.tabPrincipal.Controls.Add(this.cmbStatus);
            this.tabPrincipal.Controls.Add(this.cmbCliente);
            this.tabPrincipal.Controls.Add(this.cmbConsultor);
            this.tabPrincipal.Controls.Add(this.lblValidade);
            this.tabPrincipal.Controls.Add(this.txtValidade);
            this.tabPrincipal.Controls.Add(this.lblData);
            this.tabPrincipal.Controls.Add(this.txtData);
            this.tabPrincipal.Controls.Add(this.txtCodigo);
            this.tabPrincipal.Controls.Add(this.lblCodigo);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(794, 539);
            this.tabPrincipal.TabIndex = 1;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // mtxtTotalOrc
            // 
            this.mtxtTotalOrc.Location = new System.Drawing.Point(684, 513);
            this.mtxtTotalOrc.Mask = "999,999.999,99";
            this.mtxtTotalOrc.Name = "mtxtTotalOrc";
            this.mtxtTotalOrc.Size = new System.Drawing.Size(104, 20);
            this.mtxtTotalOrc.TabIndex = 54;
            this.mtxtTotalOrc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtTotalOrc_MaskInputRejected);
            // 
            // lblTotalOrc
            // 
            this.lblTotalOrc.AutoSize = true;
            this.lblTotalOrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrc.Location = new System.Drawing.Point(684, 495);
            this.lblTotalOrc.Name = "lblTotalOrc";
            this.lblTotalOrc.Size = new System.Drawing.Size(104, 15);
            this.lblTotalOrc.TabIndex = 53;
            this.lblTotalOrc.Text = "TOTAL LÍQUIDO";
            this.lblTotalOrc.Click += new System.EventHandler(this.lblTotalOrc_Click);
            // 
            // mtxtDescontoOrc
            // 
            this.mtxtDescontoOrc.Location = new System.Drawing.Point(601, 513);
            this.mtxtDescontoOrc.Mask = "999,999.999,99";
            this.mtxtDescontoOrc.Name = "mtxtDescontoOrc";
            this.mtxtDescontoOrc.Size = new System.Drawing.Size(77, 20);
            this.mtxtDescontoOrc.TabIndex = 52;
            // 
            // lblDescontoOrc
            // 
            this.lblDescontoOrc.AutoSize = true;
            this.lblDescontoOrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescontoOrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoOrc.Location = new System.Drawing.Point(601, 495);
            this.lblDescontoOrc.Name = "lblDescontoOrc";
            this.lblDescontoOrc.Size = new System.Drawing.Size(77, 15);
            this.lblDescontoOrc.TabIndex = 51;
            this.lblDescontoOrc.Text = "DESCONTO";
            // 
            // mtxtTotalBrutoOrc
            // 
            this.mtxtTotalBrutoOrc.Location = new System.Drawing.Point(499, 513);
            this.mtxtTotalBrutoOrc.Mask = "999,999.999,99";
            this.mtxtTotalBrutoOrc.Name = "mtxtTotalBrutoOrc";
            this.mtxtTotalBrutoOrc.Size = new System.Drawing.Size(96, 20);
            this.mtxtTotalBrutoOrc.TabIndex = 50;
            // 
            // lblTotalBrutoOrc
            // 
            this.lblTotalBrutoOrc.AutoSize = true;
            this.lblTotalBrutoOrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBrutoOrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBrutoOrc.Location = new System.Drawing.Point(499, 495);
            this.lblTotalBrutoOrc.Name = "lblTotalBrutoOrc";
            this.lblTotalBrutoOrc.Size = new System.Drawing.Size(96, 15);
            this.lblTotalBrutoOrc.TabIndex = 49;
            this.lblTotalBrutoOrc.Text = "TOTAL BRUTO";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirProduto.Image")));
            this.btnExcluirProduto.Location = new System.Drawing.Point(759, 150);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(29, 23);
            this.btnExcluirProduto.TabIndex = 48;
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirProduto.Image")));
            this.btnIncluirProduto.Location = new System.Drawing.Point(732, 150);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(26, 23);
            this.btnIncluirProduto.TabIndex = 47;
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(698, 136);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(602, 136);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(53, 13);
            this.lblDesconto.TabIndex = 45;
            this.lblDesconto.Text = "Desconto";
            // 
            // lblUnitario
            // 
            this.lblUnitario.AutoSize = true;
            this.lblUnitario.Location = new System.Drawing.Point(520, 136);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(58, 13);
            this.lblUnitario.TabIndex = 44;
            this.lblUnitario.Text = "Vlr Unitário";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(440, 136);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 43;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // mtxtTotal
            // 
            this.mtxtTotal.Enabled = false;
            this.mtxtTotal.Location = new System.Drawing.Point(656, 152);
            this.mtxtTotal.Mask = "999.999,99";
            this.mtxtTotal.Name = "mtxtTotal";
            this.mtxtTotal.Size = new System.Drawing.Size(73, 20);
            this.mtxtTotal.TabIndex = 42;
            // 
            // mtxtDesconto
            // 
            this.mtxtDesconto.Enabled = false;
            this.mtxtDesconto.Location = new System.Drawing.Point(583, 152);
            this.mtxtDesconto.Mask = "999.999,99";
            this.mtxtDesconto.Name = "mtxtDesconto";
            this.mtxtDesconto.Size = new System.Drawing.Size(69, 20);
            this.mtxtDesconto.TabIndex = 41;
            // 
            // mtxtQuantidade
            // 
            this.mtxtQuantidade.Enabled = false;
            this.mtxtQuantidade.Location = new System.Drawing.Point(433, 152);
            this.mtxtQuantidade.Mask = "999.999,99";
            this.mtxtQuantidade.Name = "mtxtQuantidade";
            this.mtxtQuantidade.Size = new System.Drawing.Size(69, 20);
            this.mtxtQuantidade.TabIndex = 40;
            // 
            // mtxtUnitario
            // 
            this.mtxtUnitario.Enabled = false;
            this.mtxtUnitario.Location = new System.Drawing.Point(508, 152);
            this.mtxtUnitario.Mask = "999.999,99";
            this.mtxtUnitario.Name = "mtxtUnitario";
            this.mtxtUnitario.Size = new System.Drawing.Size(69, 20);
            this.mtxtUnitario.TabIndex = 39;
            // 
            // cmbProduto
            // 
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(6, 151);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(419, 21);
            this.cmbProduto.TabIndex = 38;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(3, 136);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 37;
            this.lblProduto.Text = "Produto";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduto,
            this.ColumnQuantidadeProduto,
            this.ColumnVlrUnitarioProduto,
            this.ColumnDescontoProduto,
            this.ColumnTotalProduto});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(6, 178);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(782, 314);
            this.dataGridViewProdutos.TabIndex = 36;
            // 
            // ColumnProduto
            // 
            this.ColumnProduto.HeaderText = "Produto";
            this.ColumnProduto.Name = "ColumnProduto";
            this.ColumnProduto.Width = 335;
            // 
            // ColumnQuantidadeProduto
            // 
            this.ColumnQuantidadeProduto.HeaderText = "Quantidade";
            this.ColumnQuantidadeProduto.Name = "ColumnQuantidadeProduto";
            // 
            // ColumnVlrUnitarioProduto
            // 
            this.ColumnVlrUnitarioProduto.HeaderText = "Vlr Unitário";
            this.ColumnVlrUnitarioProduto.Name = "ColumnVlrUnitarioProduto";
            // 
            // ColumnDescontoProduto
            // 
            this.ColumnDescontoProduto.HeaderText = "Desconto";
            this.ColumnDescontoProduto.Name = "ColumnDescontoProduto";
            // 
            // ColumnTotalProduto
            // 
            this.ColumnTotalProduto.HeaderText = "Total";
            this.ColumnTotalProduto.Name = "ColumnTotalProduto";
            // 
            // lblFormaPgto
            // 
            this.lblFormaPgto.AutoSize = true;
            this.lblFormaPgto.Location = new System.Drawing.Point(444, 88);
            this.lblFormaPgto.Name = "lblFormaPgto";
            this.lblFormaPgto.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPgto.TabIndex = 35;
            this.lblFormaPgto.Text = "Forma de Pagamento";
            // 
            // txtFormaPgto
            // 
            this.txtFormaPgto.Enabled = false;
            this.txtFormaPgto.Location = new System.Drawing.Point(447, 104);
            this.txtFormaPgto.Name = "txtFormaPgto";
            this.txtFormaPgto.Size = new System.Drawing.Size(341, 20);
            this.txtFormaPgto.TabIndex = 34;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 88);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 33;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // Consultor
            // 
            this.Consultor.AutoSize = true;
            this.Consultor.Location = new System.Drawing.Point(3, 43);
            this.Consultor.Name = "Consultor";
            this.Consultor.Size = new System.Drawing.Size(51, 13);
            this.Consultor.TabIndex = 32;
            this.Consultor.Text = "Consultor";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(602, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(605, 59);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(183, 21);
            this.cmbStatus.TabIndex = 30;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(6, 103);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(435, 21);
            this.cmbCliente.TabIndex = 29;
            // 
            // cmbConsultor
            // 
            this.cmbConsultor.Enabled = false;
            this.cmbConsultor.FormattingEnabled = true;
            this.cmbConsultor.Location = new System.Drawing.Point(6, 59);
            this.cmbConsultor.Name = "cmbConsultor";
            this.cmbConsultor.Size = new System.Drawing.Size(435, 21);
            this.cmbConsultor.TabIndex = 28;
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(523, 44);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(48, 13);
            this.lblValidade.TabIndex = 27;
            this.lblValidade.Text = "Validade";
            // 
            // txtValidade
            // 
            this.txtValidade.Enabled = false;
            this.txtValidade.Location = new System.Drawing.Point(526, 60);
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(73, 20);
            this.txtValidade.TabIndex = 26;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(444, 44);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(447, 60);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(73, 20);
            this.txtData.TabIndex = 24;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(6, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 20);
            this.txtCodigo.TabIndex = 0;
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
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(654, 583);
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
            this.btnGravar.Location = new System.Drawing.Point(573, 583);
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
            this.btnExcluir.Location = new System.Drawing.Point(492, 583);
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
            this.btnAlterar.Location = new System.Drawing.Point(411, 583);
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
            this.btnIncluir.Location = new System.Drawing.Point(331, 583);
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
            this.btnSair.Location = new System.Drawing.Point(740, 583);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 23);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 618);
            this.Controls.Add(this.tabPadrao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Name = "frmOrcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamentos";
            this.tabPadrao.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesquisar)).EndInit();
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPadrao;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Label lblFormaPgto;
        private System.Windows.Forms.TextBox txtFormaPgto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label Consultor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbConsultor;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtValidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblUnitario;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.MaskedTextBox mtxtTotal;
        private System.Windows.Forms.MaskedTextBox mtxtDesconto;
        private System.Windows.Forms.MaskedTextBox mtxtQuantidade;
        private System.Windows.Forms.MaskedTextBox mtxtUnitario;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.MaskedTextBox mtxtTotalOrc;
        private System.Windows.Forms.Label lblTotalOrc;
        private System.Windows.Forms.MaskedTextBox mtxtDescontoOrc;
        private System.Windows.Forms.Label lblDescontoOrc;
        private System.Windows.Forms.MaskedTextBox mtxtTotalBrutoOrc;
        private System.Windows.Forms.Label lblTotalBrutoOrc;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConsultor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVlrUnitarioProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescontoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalProduto;
    }
}