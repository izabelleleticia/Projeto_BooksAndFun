using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Projeto_BooksAndFun
{
    public partial class FrmLivros : Form
    {

        public FrmLivros()
        {
            InitializeComponent();

        }
        private void CarregarLivros()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_livros WHERE estoque <> '0' ORDER BY titulo_livros;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLivros.DataSource = dt;
                dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
                dgvLivros.Columns[0].Visible = false;
                dgvLivros.Columns[1].HeaderText = "TITULO";
                dgvLivros.Columns[2].Visible = false;
                dgvLivros.Columns[3].Visible = false; 
                dgvLivros.Columns[4].Visible = false; 
                dgvLivros.Columns[5].HeaderText = "PREÇO"; 
                dgvLivros.Columns[6].HeaderText = "ESTOQUE";
                dgvLivros.Columns[7].Visible = false; 
                

                dgvLivros.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os livros. " + erro);
            }
        }
        private void FrmLivros_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadLivros().Show();
            Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pctFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
