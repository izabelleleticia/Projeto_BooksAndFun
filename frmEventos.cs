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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMenuPrincipal().Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadEvento().Show();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            CarregarEventos();
        }
        private void CarregarEventos()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_eventos WHERE status_evento LIKE @status ORDER BY nome_evento";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@status", "%" + cmbStatus.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEvento.DataSource = dt;

                dgvEvento.Columns[0].Visible = false;
                dgvEvento.Columns[1].HeaderText = "NOME";
                dgvEvento.Columns[2].HeaderText = "DESCRIÇÃO";
                dgvEvento.Columns[3].HeaderText = "INÍCIO";
                dgvEvento.Columns[4].HeaderText = "FIM";
                dgvEvento.Columns[5].HeaderText = "LOCAL";
                dgvEvento.Columns[6].HeaderText = "STATUS";
              

                dgvEvento.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro);
            }
        }
    }
       

    }
