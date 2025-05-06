using System;
using System.Data;
using System.Drawing;
using System.IO;
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
                string selecionar = "SELECT id_livros, titulo_livros, imagem, preco, estoque FROM tbl_livros WHERE estoque <> '0' ORDER BY titulo_livros;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLivros.DataSource = dt;

                // Configurar colunas
                dgvLivros.Columns["id_livros"].Visible = false;
                dgvLivros.Columns["titulo_livros"].HeaderText = "TÍTULO";
                dgvLivros.Columns["imagem"].Visible = false;
                dgvLivros.Columns["preco"].HeaderText = "PREÇO";
                dgvLivros.Columns["estoque"].HeaderText = "ESTOQUE";

                // Adicionar coluna de imagem
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "Capa";
                imgColumn.HeaderText = "CAPA";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvLivros.Columns.Add(imgColumn);

                // Caminho base das imagens
                string caminhoBase = @"C:\xampp\htdocs\sistema-LivrariaBooksAndFun\public\uploads\";

                // Carregar imagens
                foreach (DataGridViewRow row in dgvLivros.Rows)
                {
                    string caminhoRelativo = row.Cells["imagem"].Value?.ToString();

                    if (!string.IsNullOrEmpty(caminhoRelativo))
                    {
                        string caminhoCompleto = Path.Combine(caminhoBase, caminhoRelativo);


   
                        caminhoCompleto = caminhoCompleto.Replace('/', '\\');

                        if (File.Exists(caminhoCompleto))
                        {
                            try
                            {
                                Image imagemOriginal = Image.FromFile(caminhoCompleto);
                                int larguraDesejada = 100;
                                int alturaDesejada = (int)((double)imagemOriginal.Height / imagemOriginal.Width * larguraDesejada);

                                Bitmap imagemRedimensionada = new Bitmap(larguraDesejada, alturaDesejada);
                                using (Graphics g = Graphics.FromImage(imagemRedimensionada))
                                {
                                    g.DrawImage(imagemOriginal, 0, 0, larguraDesejada, alturaDesejada);
                                }

                                row.Cells["Capa"].Value = imagemRedimensionada;
                                imagemOriginal.Dispose();
                            }
                            catch (Exception ex)
                            {
                                row.Cells["Capa"].Value = null;
                                Console.WriteLine("Erro ao carregar imagem: " + ex.Message);
                            }
                        }
                        else
                        {
                            row.Cells["Capa"].Value = null;
                        }
                    }
                    else
                    {
                        row.Cells["Capa"].Value = null;
                    }
                }

                // Reorganizar a ordem das colunas
                dgvLivros.Columns["Capa"].DisplayIndex = 0;
                dgvLivros.Columns["titulo_livros"].DisplayIndex = 1;
                dgvLivros.Columns["preco"].DisplayIndex = 2;
                dgvLivros.Columns["estoque"].DisplayIndex = 3;

                dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvLivros.ClearSelection();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os livros: " + erro.Message);
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadLivros().Show();
            Hide();
        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica se a célula clicada é válida (não cabeçalho)
                if (e.RowIndex >= 0)
                {
                    // Obtém o ID do livro clicado
                    int livroId = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells["id_livros"].Value);

                    // Abre o formulário de edição e passa o ID do livro
                    editarLivro formEdicao = new editarLivro(livroId);
                    formEdicao.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o livro: " + ex.Message);
            }

            // Demais eventos...
        }
    }
}
