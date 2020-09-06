namespace ControleOrcamentos
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.btnConsultores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(12, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(121, 29);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(12, 84);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(121, 34);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnOrcamentos
            // 
            this.btnOrcamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrcamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnOrcamentos.Image")));
            this.btnOrcamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrcamentos.Location = new System.Drawing.Point(12, 124);
            this.btnOrcamentos.Name = "btnOrcamentos";
            this.btnOrcamentos.Size = new System.Drawing.Size(121, 36);
            this.btnOrcamentos.TabIndex = 3;
            this.btnOrcamentos.Text = "Orcamentos";
            this.btnOrcamentos.UseVisualStyleBackColor = true;
            this.btnOrcamentos.Click += new System.EventHandler(this.btnOrcamentos_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(12, 577);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pctImagem
            // 
            this.pctImagem.Image = ((System.Drawing.Image)(resources.GetObject("pctImagem.Image")));
            this.pctImagem.Location = new System.Drawing.Point(139, 12);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(828, 595);
            this.pctImagem.TabIndex = 6;
            this.pctImagem.TabStop = false;
            // 
            // btnConsultores
            // 
            this.btnConsultores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultores.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultores.Image")));
            this.btnConsultores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultores.Location = new System.Drawing.Point(12, 47);
            this.btnConsultores.Name = "btnConsultores";
            this.btnConsultores.Size = new System.Drawing.Size(121, 31);
            this.btnConsultores.TabIndex = 1;
            this.btnConsultores.Text = "Consultores";
            this.btnConsultores.UseVisualStyleBackColor = true;
            this.btnConsultores.Click += new System.EventHandler(this.btnConsultaPrecos_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 617);
            this.Controls.Add(this.btnConsultores);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnClientes);
            this.Name = "frmMenuPrincipal";
            this.Text = "SISORC - Controle de Orçamentos";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Button btnConsultores;
    }
}

