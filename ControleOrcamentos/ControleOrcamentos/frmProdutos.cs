using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleOrcamentos
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Chama menu principal
            var vMenuPrincipal = new frmMenuPrincipal();
            this.Close();
            vMenuPrincipal.Show();
        }

        private void lblUn_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            // Chama cadastro de marcas
            var vMarcas = new frmMarcas();
            this.Hide();
            vMarcas.Show();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            // Chama cadastro de grupos
            var vGrupos = new frmGrupos();
            this.Hide();
            vGrupos.Show();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
