using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_BooksAndFun
{
    public partial class editarLivro : Form
    {
        private int livroId;
        private string imagemAtual = ""; // guarda a imagem existente, caso nenhuma nova seja selecionada


        public editarLivro(int id)
        {
            InitializeComponent();
            livroId = id;
            CarregarCombos();  // Carregar os ComboBoxes antes de carregar os dados
            CarregarDadosLivro();

        }

        private void CarregarDadosLivro()
        {
            try
            {
                Banco.Conectar();

                // Consulta SQL para buscar os dados do livro
                string consulta = @"SELECT * FROM tbl_livros 
                            WHERE id_livros = @idLivro"; // Certifique-se de que o nome da coluna está correto
                MySqlCommand cmd = new MySqlCommand(consulta, Banco.conexao);
                cmd.Parameters.AddWithValue("@idLivro", livroId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Preenche os campos do formulário com os dados do livro
                    txtNomeLivro.Text = reader["titulo_livros"].ToString();
                    txtAnoPub.Text = reader["ano_publicacao"].ToString();
                    txtPreco.Text = reader["preco"].ToString();
                    txtQuantidade.Text = reader["estoque"].ToString();

                    // Preencher ComboBoxes com o ID correspondente
                    cmbAutor.SelectedValue = reader["id_autor"];
                    cmbGenero.SelectedValue = reader["id_genero"];
                    cmbEditora.SelectedValue = reader["id_editora"];
                    cmbSerie.SelectedValue = reader["id_serie"];

                    // Carregar imagem
                    string caminhoImagem = reader["imagem"].ToString();

                    // Caminho absoluto para a pasta 'livros' no seu diretório de uploads
                    string caminhoCompleto = @"C:\xampp\htdocs\sistema-LivrariaBooksAndFun\public\uploads\" + caminhoImagem;

                    // Verifique o caminho completo
                    MessageBox.Show("Caminho da imagem: " + caminhoCompleto);

                    // Verifique se o arquivo realmente existe
                    if (File.Exists(caminhoCompleto))
                    {
                        pctLivro.Image = Image.FromFile(caminhoCompleto);
                    }
                    else
                    {
                        pctLivro.Image = null; // Caso a imagem não seja encontrada, o campo fica vazio
                        MessageBox.Show("Imagem não encontrada. Verifique o caminho da imagem.");
                    }
                }

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do livro: " + ex.Message);
            }
        }

        private void CarregarCombos()
        {
            try
            {
                Banco.Conectar();

                // Carregar Autores
                string queryAutores = "SELECT id_autor, nome_autor FROM tbl_autores ORDER BY nome_autor";
                MySqlDataAdapter daAutor = new MySqlDataAdapter(queryAutores, Banco.conexao);
                DataTable dtAutor = new DataTable();
                daAutor.Fill(dtAutor);
                cmbAutor.DataSource = dtAutor;
                cmbAutor.DisplayMember = "nome_autor";
                cmbAutor.ValueMember = "id_autor";

                // Carregar Editoras
                string queryEditoras = "SELECT id_editora, nome_editora FROM tbl_editoras ORDER BY nome_editora";
                MySqlDataAdapter daEditora = new MySqlDataAdapter(queryEditoras, Banco.conexao);
                DataTable dtEditora = new DataTable();
                daEditora.Fill(dtEditora);
                cmbEditora.DataSource = dtEditora;
                cmbEditora.DisplayMember = "nome_editora";
                cmbEditora.ValueMember = "id_editora";

                // Carregar Séries
                string querySeries = "SELECT id_serie, nome_serie FROM tbl_series ORDER BY nome_serie";
                MySqlDataAdapter daSerie = new MySqlDataAdapter(querySeries, Banco.conexao);
                DataTable dtSerie = new DataTable();
                daSerie.Fill(dtSerie);
                cmbSerie.DataSource = dtSerie;
                cmbSerie.DisplayMember = "nome_serie";
                cmbSerie.ValueMember = "id_serie";

                // Carregar Gêneros
                string queryGeneros = "SELECT id_genero, descricao_genero FROM tbl_generos ORDER BY descricao_genero";
                MySqlDataAdapter daGenero = new MySqlDataAdapter(queryGeneros, Banco.conexao);
                DataTable dtGenero = new DataTable();
                daGenero.Fill(dtGenero);
                cmbGenero.DataSource = dtGenero;
                cmbGenero.DisplayMember = "descricao_genero";
                cmbGenero.ValueMember = "id_genero";

                Banco.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados dos comboboxes: " + ex.Message);
            }
        }
        private void EditarLivro()
        {
            try
            {
                Banco.Conectar();

                string consulta = @"UPDATE tbl_livros 
                            SET titulo_livros = @titulo, 
                                ano_publicacao = @ano, 
                                preco = @preco, 
                                estoque = @estoque, 
                                id_autor = @idAutor, 
                                id_genero = @idGenero, 
                                id_editora = @idEditora, 
                                id_serie = @idSerie, 
                                imagem = @imagem 
                            WHERE id_livros = @idLivro";

                MySqlCommand cmd = new MySqlCommand(consulta, Banco.conexao);

                cmd.Parameters.AddWithValue("@titulo", txtNomeLivro.Text);
                cmd.Parameters.AddWithValue("@ano", txtAnoPub.Text);
                cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
                cmd.Parameters.AddWithValue("@estoque", txtQuantidade.Text);
                cmd.Parameters.AddWithValue("@idAutor", cmbAutor.SelectedValue);
                cmd.Parameters.AddWithValue("@idGenero", cmbGenero.SelectedValue);
                cmd.Parameters.AddWithValue("@idEditora", cmbEditora.SelectedValue);
                cmd.Parameters.AddWithValue("@idSerie", cmbSerie.SelectedValue);
                cmd.Parameters.AddWithValue("@idLivro", livroId); // importante

                // Define o nome da imagem a ser salva no banco
                string nomeImagemFinal;

                if (!string.IsNullOrEmpty(Variaveis.caminhoImagem))
                {
                    string nomeImagem = Path.GetFileName(Variaveis.caminhoImagem);
                    string destino = Path.Combine(@"C:\xampp\htdocs\sistema-LivrariaBooksAndFun\public\uploads\livros   ", nomeImagem);

                    pctLivro.Image.Save(destino);
                    nomeImagemFinal = @"livros\" + nomeImagem;

                    // Mostra o caminho salvo no banco
                    MessageBox.Show("Caminho salvo no banco: " + nomeImagemFinal);

                    // Mostra o caminho completo salvo no disco
                    MessageBox.Show("Imagem salva em: " + destino);
                }
                else
                {
                    nomeImagemFinal = imagemAtual; // usa a imagem antiga
                }


                cmd.Parameters.AddWithValue("@imagem", nomeImagemFinal);

                cmd.ExecuteNonQuery();

                Banco.Desconectar();

                MessageBox.Show("Livro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o livro: " + ex.Message);
            }
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecionar imagem";
                ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Variaveis.caminhoImagem = ofd.FileName;
                    pctLivro.Image = Image.FromFile(Variaveis.caminhoImagem);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EditarLivro();
        }
        private void ExcluirLivro()
        {
            try
            {
                Banco.Conectar();

                // Primeiro, recupera o caminho da imagem antes de excluir o registro
                string consultaImagem = "SELECT imagem FROM tbl_livros WHERE id_livros = @idLivro";
                MySqlCommand cmdImagem = new MySqlCommand(consultaImagem, Banco.conexao);
                cmdImagem.Parameters.AddWithValue("@idLivro", livroId);

                object resultado = cmdImagem.ExecuteScalar();
                string caminhoRelativoImagem = resultado != null ? resultado.ToString() : "";

                // Exclui o livro do banco
                string consulta = "UPDATE tbl_livros set estoque = 0 where id_livros =  @idLivro";
                MySqlCommand cmd = new MySqlCommand(consulta, Banco.conexao);
                cmd.Parameters.AddWithValue("@idLivro", livroId);
                cmd.ExecuteNonQuery();

                Banco.Desconectar();

                // Exclui a imagem do diretório, se existir
                if (!string.IsNullOrEmpty(caminhoRelativoImagem))
                {
                    string caminhoImagemCompleto = Path.Combine(@"C:\xampp\htdocs\sistema-LivrariaBooksAndFun\public\", caminhoRelativoImagem);
                    if (File.Exists(caminhoImagemCompleto))
                    {
                        File.Delete(caminhoImagemCompleto);
                    }
                }

                MessageBox.Show("Livro excluído com sucesso!");
                this.Close(); // Fecha o formulário, se desejar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o livro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirLivro();
        }
    }
}