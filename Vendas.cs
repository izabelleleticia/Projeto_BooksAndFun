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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            dtCompra.Format = DateTimePickerFormat.Custom;
            dtCompra.CustomFormat = "dd/MM/yyyy HH:mm"; // Formato dia/mês/ano hora:minuto
            dtCompra.ShowUpDown = true; // Remove o calendário e permite ajustar manualmente
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

                dgvLivros.Columns[0].HeaderText = "ID";
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

        private void Vendas_Load(object sender, EventArgs e)
        {
            CarregarLivros();
            CarregarClienteStatusTodos();
        }

        private void CarregarClienteStatusTodos()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@status", "%" + cmbStatus.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;

                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].Visible = false;
                dgvCliente.Columns[4].Visible = false;
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[6].Visible = false;
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

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
