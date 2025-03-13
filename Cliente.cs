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

namespace Projeto_BooksAndFun
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }
        private void CarregarCliente()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente WHERE status_cliente <> 'DESATIVADO' ORDER BY nome_cliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;

                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[4].HeaderText = "BAIRRO";
                dgvCliente.Columns[5].HeaderText = "CIDADE";
                dgvCliente.Columns[6].HeaderText = "UF";
                dgvCliente.Columns[7].HeaderText = "TELEFONE";
                dgvCliente.Columns[8].HeaderText = "EMAIL";
                dgvCliente.Columns[9].Visible = false;
                dgvCliente.Columns[10].Visible = false;
                dgvCliente.Columns[11].HeaderText = "STATUS";

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro);
            }
        }
        private void CarregarClienteNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente WHERE nome_cliente LIKE @nome ORDER BY nome_cliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@nome", "%" + txtNome.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;

                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[4].HeaderText = "BAIRRO";
                dgvCliente.Columns[5].HeaderText = "CIDADE";
                dgvCliente.Columns[6].HeaderText = "UF";
                dgvCliente.Columns[7].HeaderText = "TELEFONE";
                dgvCliente.Columns[8].HeaderText = "EMAIL";
                dgvCliente.Columns[9].Visible = false;
                dgvCliente.Columns[10].Visible = false;
                dgvCliente.Columns[11].HeaderText = "STATUS";

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarClienteNome();
            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarCliente();
            }
        }
        private void CarregarClienteStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente WHERE status_cliente LIKE @status ORDER BY nome_cliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@status", "%" + cmbStatus.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;

                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[4].HeaderText = "BAIRRO";
                dgvCliente.Columns[5].HeaderText = "CIDADE";
                dgvCliente.Columns[6].HeaderText = "UF";
                dgvCliente.Columns[7].HeaderText = "TELEFONE";
                dgvCliente.Columns[8].HeaderText = "EMAIL";
                dgvCliente.Columns[9].Visible = false;
                dgvCliente.Columns[10].Visible = false;
                dgvCliente.Columns[11].HeaderText = "STATUS";

                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtNome.Enabled = false;
                CarregarClienteStatus();
            }
            else
            {
                txtNome.Enabled = true;
                CarregarCliente();
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadastroCliente().Show();
            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            new frmMenuPrincipal();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }

    }
}
