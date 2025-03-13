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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }
        private void CarregarFuncionario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_funcionario WHERE status_funcionario <> 'DESATIVADO' ORDER BY nome_funcionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFuncionario.DataSource = dt;

                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME";
                dgvFuncionario.Columns[2].HeaderText = "TELEFONE";
                dgvFuncionario.Columns[3].HeaderText = "EMAIL";
                dgvFuncionario.Columns[4].Visible = false;
                dgvFuncionario.Columns[5].HeaderText = "STATUS";

                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os funcionários. " + erro);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Hide();
            //new frmCadastroFuncionario();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            
        }
    }
}
