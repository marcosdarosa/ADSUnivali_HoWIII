using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControleOrcamentos
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Chama cadastro de clientes
            var vClientes = new frmClientes();
            this.Hide();
            vClientes.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultaPrecos_Click(object sender, EventArgs e)
        {
            // Chama cadastro de consultoress
            var vConsultores = new frmConsultores();
            this.Hide();
            vConsultores.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            // Chama cadastro de produtos
            var vProdutos = new frmProdutos();
            this.Hide();
            vProdutos.Show();
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            // Chama módulo de orçamentos
            var vOrcamentos = new frmOrcamentos();
            this.Hide();
            vOrcamentos.Show();
        }
    }
}
