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

            // Define a cor de fundo do DataGridView
            dgvLivros.BackgroundColor = Color.FromArgb(92, 33, 81); // Invertido: fundo branco
            dgvLivros.GridColor = Color.FromArgb(92, 33, 81); // Cor das grades roxa

            // Estiliza as células normais (fundo roxo escuro, texto branco)

            dgvLivros.DefaultCellStyle.ForeColor = Color.White; // Texto branco
            dgvLivros.DefaultCellStyle.Font = new Font("Britannic", 16);

            // Estiliza as células quando selecionadas (fundo branco, texto preto)
            dgvLivros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(92, 33, 81); // Cabeçalho fundo branco
            dgvLivros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(135, 122, 178); // Invertido: roxo claro
            dgvLivros.DefaultCellStyle.SelectionForeColor = Color.White; // Texto preto

            // Configuração do cabeçalho (fundo roxo escuro, texto branco)
            dgvLivros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto roxo escuro
            dgvLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Britannic Bold", 16, FontStyle.Bold);


            // Ativa a mudança de cor no cabeçalho
            dgvLivros.EnableHeadersVisualStyles = false;

            // 🔹 AutoSize das colunas (ajuste automático ao conteúdo)
            dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 🔹 AutoSize das linhas (ajuste automático ao conteúdo)
            dgvLivros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


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
                // Estilizando todo o cabeçalho
                dgvLivros.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue; // Cor de fundo
                dgvLivros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Cor da fonte




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

   
    }
}
