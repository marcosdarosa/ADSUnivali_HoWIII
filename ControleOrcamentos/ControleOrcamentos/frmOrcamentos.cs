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
    public partial class frmOrcamentos : Form
    {
        public frmOrcamentos()
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

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalOrc_Click(object sender, EventArgs e)
        {

        }

        private void mtxtTotalOrc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
