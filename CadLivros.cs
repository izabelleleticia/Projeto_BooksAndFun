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
using System.IO;

namespace Projeto_BooksAndFun
{
    public partial class CadLivros : Form
    {
        string caminhoImagem = "";
        string nomeArquivoImagem = "";

        public CadLivros()
        {
            InitializeComponent();
        }

        private void CarregarEditoras()
        {
            try
            {
                Banco.Conectar(); // Conecta ao banco de dados

                string selecionar = @"SELECT DISTINCT e.* 
                              FROM tbl_editoras e
                              INNER JOIN tbl_livros l ON e.id_editora = l.id_editora;";

                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEditora.DataSource = dt; // Exibe os dados no DataGridView

                Banco.Desconectar(); // Fecha a conexão com o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar editoras: " + erro.Message);
            }
        }
        private void CarregarGeneros()
        {
            try
            {
                Banco.Conectar(); // Conecta ao banco de dados

                string selecionar = @"SELECT DISTINCT e.* 
                              FROM tbl_generos e
                              INNER JOIN tbl_livros l ON e.id_genero = l.id_genero;";

                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGenero.DataSource = dt; // Exibe os dados no DataGridView

                Banco.Desconectar(); // Fecha a conexão com o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar editoras: " + erro.Message);
            }
        }
           private void CadastrarLivros()
        {
            try
            {
                Banco.Conectar();

                // Define o caminho para salvar a imagem
                string pastaDestino = Path.Combine(Application.StartupPath, @"..\..\..\uploads\livros");
                Directory.CreateDirectory(pastaDestino); // Garante que a pasta exista

                string destinoImagem = Path.Combine(pastaDestino, nomeArquivoImagem);
                File.Copy(caminhoImagem, destinoImagem, true); // Salva a imagem no destino

                string caminhoRelativo = $"livros/{nomeArquivoImagem}"; // Isso vai pro banco

                string inserir = @"INSERT INTO tbl_livros 
            (titulo_livros, imagem, id_autor, id_genero, ano_publicacao, preco, estoque, id_editora)
            VALUES (@titulo, @imagem, @IdAutor, @IdGenero, @anoPub, @preco, @estoque, @IdEditora);";

                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@titulo", Variaveis.titulo);
                cmd.Parameters.AddWithValue("@imagem", caminhoRelativo); // <- Aqui
                cmd.Parameters.AddWithValue("@IdAutor", Variaveis.IdAutor);
                cmd.Parameters.AddWithValue("@IdGenero", Variaveis.IdGenero);
                cmd.Parameters.AddWithValue("@anoPub", Variaveis.anoPub);
                cmd.Parameters.AddWithValue("@preco", Variaveis.preco);
                cmd.Parameters.AddWithValue("@estoque", Variaveis.estoque);
                cmd.Parameters.AddWithValue("@IdEditora", Variaveis.IdEditora);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + erro.Message);
            }
        } 
        private void CadLivros_Load(object sender, EventArgs e)
        {
            CarregarEditoras();
            CarregarGeneros();

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            new FrmLivros();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.titulo = txtNomeLivro.Text;
            Variaveis.IdAutor = txtIdAutor.Text;
            Variaveis.IdGenero = txtIDGenero.Text;
            Variaveis.anoPub = txtAnoPub.Text;
            Variaveis.preco = txtPreco.Text;
            Variaveis.estoque = txtQuantidade.Text;
            Variaveis.IdEditora = txtIDEditora.Text;
            CadastrarLivros();
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                caminhoImagem = dialog.FileName;
                nomeArquivoImagem = Path.GetFileName(caminhoImagem);
                pctLivro.Image = Image.FromFile(caminhoImagem);
            }
        }
    }
}


