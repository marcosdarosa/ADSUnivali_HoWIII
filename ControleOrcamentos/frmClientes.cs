using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace ControleOrcamentos
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        
        private MySqlConnectionStringBuilder ConectaBanco()
        {
            //Criação da estrutura da conexão com o banco e passa os parametros
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "controle_orcamentos";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            
            return conexaoBD;
        }

        private void ExecutaComandoBanco(string pComando)
        {
            //Realizando a conexão com o banco
            MySqlConnectionStringBuilder conexaoBD = ConectaBanco();
            MySqlConnection abreConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                abreConexaoBD.Open(); // Inicia (abertura) conexão com o banco de dados

                MySqlCommand executacomandoMySql = abreConexaoBD.CreateCommand(); //Cria um comando SQL
                executacomandoMySql.CommandText = pComando;
                executacomandoMySql.ExecuteNonQuery();

                abreConexaoBD.Close(); //Finaliza (fechamento) conexão com o banco de dados
            }
            catch (Exception)
            {
                MessageBox.Show("Atenção! Não foi possivel realizar a conexão com o banco de dados! ");

            }

            HabilitaCampos(false); //Desativa os campos e botões

        }

        private void Pesquisar(string pComando)
        {
            //Realizando a conexão com o banco
            MySqlConnectionStringBuilder conexaoBD = ConectaBanco();
            MySqlConnection abreConexaoBD = new MySqlConnection(conexaoBD.ToString());

            try
            {
                abreConexaoBD.Open(); //Inicia (abertura) conexão com o banco de dados

                MySqlCommand executacomandoMySql = abreConexaoBD.CreateCommand(); //Crio um comando SQL
                executacomandoMySql.CommandText = pComando;
                MySqlDataReader reader = executacomandoMySql.ExecuteReader();  //Executa comando no banco de dados para localizar registros

                dataGridViewPesquisar.Rows.Clear(); // Limpa o grid
                
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewPesquisar.Rows[0].Clone(); //Realiza um cast e clona o registro
                    row.Cells[0].Value = reader.GetInt32(0); // idCliente
                    row.Cells[1].Value = reader.GetInt32(1); // ativoCliente
                    row.Cells[2].Value = reader.GetString(2); // nomeCliente
                    row.Cells[3].Value = reader.GetString(3); // cpfCliente
                    row.Cells[4].Value = reader.GetString(4); // rgCliente
                    row.Cells[5].Value = reader.GetString(5); // fonefixoCliente
                    row.Cells[6].Value = reader.GetString(6); // fonecelularCliente
                    row.Cells[7].Value = reader.GetString(7); // emailCliente
                    row.Cells[8].Value = reader.GetString(8); // cepCliente
                    row.Cells[9].Value = reader.GetString(9); // logradouroCliente
                    row.Cells[10].Value = reader.GetInt32(10); // numeroCliente
                    row.Cells[11].Value = reader.GetString(11); // complementoCliente
                    row.Cells[12].Value = reader.GetString(12); // bairroCliente
                    row.Cells[13].Value = reader.GetString(13); // cidadeCliente
                    row.Cells[14].Value = reader.GetString(14); // estadoCliente
                    dataGridViewPesquisar.Rows.Add(row); // Adiciona a linha no grid
                }

                abreConexaoBD.Close(); // Finaliza (fechamento) conexão com o banco de dados
            }

            catch (Exception)
            {
                MessageBox.Show("Atenção! Não foi possivel realizar a conexão com o banco de dados! ");
            }

        }

        private void HabilitaCampos(bool pHabilita)
        {
            // Ativa os campos
            chkAtivo.Enabled = pHabilita;   
            txtNome.Enabled = pHabilita;
            mtxtCpf.Enabled = pHabilita;
            txtRg.Enabled = pHabilita;
            mtxtFoneFixo.Enabled = pHabilita;
            mtxtFoneCelular.Enabled = pHabilita;
            txtEmail.Enabled = pHabilita;
            mtxtCep.Enabled = pHabilita;
            txtLogradouro.Enabled = pHabilita;
            txtNumero.Enabled = pHabilita;
            txtComplemento.Enabled = pHabilita;
            txtBairro.Enabled = pHabilita;
            txtCidade.Enabled = pHabilita;
            txtEstado.Enabled = pHabilita;

            // Ativa os botões Gravar e Cancelar e Desativa os demais botões
            btnGravar.Enabled = pHabilita;
            btnCancelar.Enabled = pHabilita;
            btnPesquisar.Enabled = !pHabilita;
            btnIncluir.Enabled = !pHabilita;
            btnAlterar.Enabled = !pHabilita;
            btnExcluir.Enabled = !pHabilita;
            btnSair.Enabled = !pHabilita;

            tabPadrao.SelectedTab = tabPrincipal; // Habilita aba Principal

            if (pHabilita == true)
            {
                txtNome.Focus(); // Coloca o foco no campo nome
            }

            else
            {
                btnIncluir.Focus(); // Coloca o foco no botão incluir
            }
        }

        private void LimpaCampos()
        {
            // Limpa os campos
            txtCodigo.Text = "";
            chkAtivo.Text = "";
            txtNome.Text = "";
            mtxtCpf.Text = "";
            txtRg.Text = "";
            mtxtFoneFixo.Text = "";
            mtxtFoneCelular.Text = "";
            txtEmail.Text = "";
            mtxtCep.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";

            dataGridViewPesquisar.Rows.Clear(); // Limpa grade de pesquisa
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chama menu principal
            var vMenuPrincipal = new frmMenuPrincipal();
            this.Close();
            vMenuPrincipal.Show();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(true); // Habilita os campos e botões

            LimpaCampos(); //Limpa os campos
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(false); // Desativa os campos e botões

            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                LimpaCampos(); //Limpa os campos quando for uma inclusão
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string comandoSQL = "";

            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Atenção! É obrigatório o preenchimento do nome!"); // Valida o preenchimento do campo nome
                return;
            }

            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                // Comando para gravar inclusão (INSERT)
                comandoSQL = "INSERT INTO clientes (ativoCliente, nomeCliente, cpfCliente, rgCliente, fonefixoCliente, fonecelularCliente, emailCliente, cepCliente, logradouroCLiente, numeroCliente, complementoCliente, bairroCliente, cidadeCliente, estadoCliente) " +
                               "VALUES('" + chkAtivo.Text + "', '" +
                                            txtNome.Text + "', '" +
                                            mtxtCpf.Text + "', '" +
                                            txtRg.Text + "', '" +
                                            mtxtFoneFixo.Text + "', '" +
                                            mtxtFoneCelular.Text + "', '" +
                                            txtEmail.Text + "', '" +
                                            mtxtCep.Text + "', '" +
                                            txtLogradouro.Text + "', '" +
                                            txtNumero.Text + "', '" +
                                            txtComplemento.Text + "', '" +
                                            txtBairro.Text + "', '" +
                                            txtCidade.Text + "', '" +
                                            txtEstado.Text + "')";
            }

            else
            {
                // Comando para gravar alteração (UPDATE)
                comandoSQL = "UPDATE clientes SET " +
                                    "nomeCliente = '" + txtNome.Text + "', " +
                                    "ativoCliente = '" + chkAtivo.Text + "', " +
                                    "cpfCliente = '" + mtxtCpf.Text + "', " +
                                    "rgCliente = '" + txtRg.Text + "', " +
                                    "fonefixoCliente = '" + mtxtFoneFixo.Text + "', " +
                                    "fonecelularCliente = '" + mtxtFoneCelular.Text + "', " +
                                    "emailCliente = '" + txtEmail.Text + "', " +
                                    "cepCliente = '" + mtxtCep.Text + "', " +
                                    "logradouroCliente = '" + txtLogradouro.Text + "', " +
                                    "numeroCliente = '" + txtNumero.Text + "', " +
                                    "complementoCliente = '" + txtComplemento.Text + "', " +
                                    "bairroCliente = '" + txtBairro.Text + "', " +
                                    "cidadeCliente = '" + txtCidade.Text + "', " +
                                    "estadoCliente = '" + txtEstado.Text + "' " +
                            " WHERE idCliente = '" + txtCodigo.Text + "'";
            }

            ExecutaComandoBanco(comandoSQL); // Executa comando no banco de dados para gravação de registro
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string comandoSQL = "";

            // Realização seleção de todos os registros caso não for informado a pesquisa
            if (String.IsNullOrEmpty(txtPesquisar.Text))
            {
                comandoSQL = "SELECT * FROM clientes";

                Pesquisar(comandoSQL);
            }
            
            // Realiza a seleção dos registros através aplicando o filtro pelo código ou nome
            else
            {
                comandoSQL = "SELECT * FROM clientes WHERE idCliente = '" + txtPesquisar.Text + "' OR nomeCliente LIKE '%" + txtPesquisar.Text + "%'";

                Pesquisar(comandoSQL);
            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                HabilitaCampos(true); // Habilita os campos e botões
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text))
            {
                // Solicita confirmação ao usuário para exclusão do registro
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    // Comando para gravar exclusão (DELETE)
                    string comandoSQL = "DELETE FROM clientes WHERE idCliente = '" + txtCodigo.Text + "'";

                    ExecutaComandoBanco(comandoSQL); // Executa comando no banco de dados para exclusão do registro

                    LimpaCampos(); //Limpa os campos
                }
            }
        }

        private void dataGridViewPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ao selecionar o registro no grid, habilita na aba principal os dados para edição
            if (dataGridViewPesquisar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewPesquisar.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionada
                txtCodigo.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnCodigo"].FormattedValue.ToString();
                chkAtivo.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnAtivo"].FormattedValue.ToString();
                txtNome.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                mtxtCpf.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnCPF"].FormattedValue.ToString();
                txtRg.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnRG"].FormattedValue.ToString();
                mtxtFoneFixo.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnFoneFixo"].FormattedValue.ToString();
                mtxtFoneCelular.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnFoneCelular"].FormattedValue.ToString();
                txtEmail.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnEmail"].FormattedValue.ToString();
                mtxtCep.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnCEP"].FormattedValue.ToString();
                txtLogradouro.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnLogradouro"].FormattedValue.ToString();
                txtNumero.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnNumero"].FormattedValue.ToString();
                txtComplemento.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnComplemento"].FormattedValue.ToString();
                txtBairro.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnBairro"].FormattedValue.ToString();
                txtCidade.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnCidade"].FormattedValue.ToString();
                txtEstado.Text = dataGridViewPesquisar.Rows[e.RowIndex].Cells["ColumnEstado"].FormattedValue.ToString();

                tabPadrao.SelectedTab = tabPrincipal;
                tabPrincipal.Focus();
            }
        }

        private void tabPadrao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
