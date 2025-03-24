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
        private void FrmLivros_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

   
    }
}
