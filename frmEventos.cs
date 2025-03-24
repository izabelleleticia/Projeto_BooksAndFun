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

            // Define a cor de fundo do DataGridView
            // dgvEvento.BackgroundColor = Color.FromArgb(92, 33, 81); // Invertido: fundo branco
            // dgvEvento.GridColor = Color.FromArgb(92, 33, 81); // Cor das grades roxa

            // Estiliza as células normais (fundo roxo escuro, texto branco)

            //dgvEvento.DefaultCellStyle.ForeColor = Color.White; // Texto branco
            //dgvEvento.DefaultCellStyle.Font = new Font("Britannic", 16);

            // Estiliza as células quando selecionadas (fundo branco, texto preto)
            //dgvEvento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(92, 33, 81); // Cabeçalho fundo branco
            //dgvEvento.DefaultCellStyle.SelectionBackColor = Color.FromArgb(135, 122, 178); // Invertido: roxo claro
            //dgvEvento.DefaultCellStyle.SelectionForeColor = Color.White; // Texto preto

            // Configuração do cabeçalho (fundo roxo escuro, texto branco)
            //dgvEvento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto roxo escuro
            //dgvEvento.ColumnHeadersDefaultCellStyle.Font = new Font("Britannic Bold", 16, FontStyle.Bold);


            // Ativa a mudança de cor no cabeçalho
            // dgvEvento.EnableHeadersVisualStyles = false;

            // 🔹 AutoSize das colunas (ajuste automático ao conteúdo)
            dgvEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 🔹 AutoSize das linhas (ajuste automático ao conteúdo)
            dgvEvento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadEvento().Show();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            UpdateEventosStatus();
        }
        private void UpdateEventosStatus()
        {
            try
            {
                Banco.Conectar();

                // A consulta UPDATE não precisa do DataAdapter.
                string atualizar = "UPDATE tbl_eventos SET status_evento = 'INATIVO' WHERE data_hora_fim < NOW()";

                // Executa o comando UPDATE diretamente
                MySqlCommand cmd = new MySqlCommand(atualizar, Banco.conexao);

                // Executa o comando de atualização
                cmd.ExecuteNonQuery();

                // Agora, vamos buscar os dados para exibir no DataGrid
                string selectQuery = "SELECT * FROM tbl_eventos WHERE status_evento = 'INATIVO'"; // Exemplo de consulta
                MySqlDataAdapter da = new MySqlDataAdapter(selectQuery, Banco.conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);
                Banco.Desconectar();
                CarregarEventos();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os eventos. " + erro);
            }
        }




        private void CarregarEventos()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_eventos WHERE status_evento = 'ATIVO'";
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
        private void CarregarTodosEventos()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_eventos";
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
        private void CarregarEventosInativos()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_eventos where status_evento = 'INATIVO'";
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

        private void dgvEvento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMenuPrincipal();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtNome.Enabled = false;
                CarregarEventos();
            }
            else if (cmbStatus.Text == "INATIVO")
            {
                CarregarEventosInativos();
            }


            else if (cmbStatus.Text == "TODOS")
            {
                CarregarTodosEventos();


            }
        }


       private void dgvEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Verifica se a célula clicada é válida
            {
                DataGridViewRow row = dgvEvento.Rows[e.RowIndex];

                // Usando índice para acessar a célula, já que a coluna está invisível
                if (row.Cells[0].Value != DBNull.Value && row.Cells[0].Value != null)
                {
                    try
                    {
                        // Tenta converter o valor da célula "id_evento" (primeira célula)
                        Variaveis.idEventoSelecionado = Convert.ToString(row.Cells[0].Value);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show($"Erro ao converter o ID do evento: {ex.Message}", "Erro de Conversão");
                    }
                }
                else
                {
                    MessageBox.Show("O evento selecionado não possui um ID válido.", "Erro");
                }
            }
        }


    }
}
