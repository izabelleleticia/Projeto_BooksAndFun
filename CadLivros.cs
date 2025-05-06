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

        //private void CarregarEditoras()
        //{
        //    try
        //    {
        //        Banco.Conectar(); // Conecta ao banco de dados

        //        string selecionar = @"SELECT DISTINCT e.* 
        //                      FROM tbl_editoras e
        //                      INNER JOIN tbl_livros l ON e.id_editora = l.id_editora;";

        //        MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dgvEditora.DataSource = dt; // Exibe os dados no DataGridView

        //        Banco.Desconectar(); // Fecha a conexão com o banco
        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show("Erro ao carregar editoras: " + erro.Message);
        //    }
        //}
        //private void CarregarGeneros()
        //{
        //    try
        //    {
        //        Banco.Conectar(); // Conecta ao banco de dados

        //        string selecionar = @"SELECT DISTINCT e.* 
        //                      FROM tbl_generos e
        //                      INNER JOIN tbl_livros l ON e.id_genero = l.id_genero;";

        //        MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
        //        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dgvGenero.DataSource = dt; // Exibe os dados no DataGridView

        //        Banco.Desconectar(); // Fecha a conexão com o banco
        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show("Erro ao carregar editoras: " + erro.Message);
        //    }
        //}
        private void CadastrarLivros()
        {
            try
            {
                Banco.Conectar();

                // Define o caminho para salvar a imagem
                string pastaDestino = @"C:\xampp\htdocs\sistema-LivrariaBooksAndFun\public\uploads\livros"; // Caminho correto para a imagem
                Directory.CreateDirectory(pastaDestino); // Garante que a pasta exista

                string destinoImagem = Path.Combine(pastaDestino, nomeArquivoImagem); // Caminho completo da imagem
                File.Copy(caminhoImagem, destinoImagem, true); // Salva a imagem no destino

                string caminhoRelativo = $"uploads/livros/{nomeArquivoImagem}"; // Caminho relativo que será salvo no banco de dados

                // Busca os IDs com base no nome selecionado nos ComboBoxes
                int idAutor = BuscarIdPorComboBox(cmbAutor, "tbl_autores", "nome_autor");
                int idGenero = BuscarIdPorComboBox(cmbGenero, "tbl_generos", "descricao_genero");
                int idEditora = BuscarIdPorComboBox(cmbEditora, "tbl_editoras", "nome_editora");
                int idSerie = BuscarIdPorComboBox(cmbSerie, "tbl_series", "nome_serie");

                string inserir = @"INSERT INTO tbl_livros 
        (titulo_livros, imagem, id_autor, id_genero, ano_publicacao, preco, estoque, id_editora, id_serie)
        VALUES (@titulo, @imagem, @IdAutor, @IdGenero, @anoPub, @preco, @estoque, @IdEditora, @IdSerie);";

                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@titulo", txtNomeLivro.Text.Trim());
                cmd.Parameters.AddWithValue("@imagem", caminhoRelativo);
                cmd.Parameters.AddWithValue("@IdAutor", idAutor);
                cmd.Parameters.AddWithValue("@IdGenero", idGenero);
                cmd.Parameters.AddWithValue("@anoPub", txtAnoPub.Text.Trim());
                cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text.Trim()));
                cmd.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtQuantidade.Text.Trim()));
                cmd.Parameters.AddWithValue("@IdEditora", idEditora);
                cmd.Parameters.AddWithValue("@IdSerie", idSerie);

                cmd.ExecuteNonQuery();

                // Mensagem de sucesso
                MessageBox.Show("Livro cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Desconecta do banco
                Banco.Desconectar();

                // Redireciona para o formulário de listagem de livros
                FrmLivros formListagem = new FrmLivros(); // Cria a instância do formulário de listagem
                formListagem.Show(); // Exibe o formulário de listagem

                this.Hide(); // Oculta o formulário atual (Cadastro)
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + erro.Message);
            }
        }


        private int BuscarIdAutor(ComboBox combo)
        {
            return BuscarIdPorComboBox(combo, "tbl_autores", "nome_autor");
        }

        private int BuscarIdGenero(ComboBox combo)
        {
            return BuscarIdPorComboBox(combo, "tbl_generos", "descricao_genero");
        }

        private int BuscarIdEditora(ComboBox combo)
        {
            return BuscarIdPorComboBox(combo, "tbl_editoras", "nome_editora");
        }

        private int BuscarIdSerie(ComboBox combo)
        {
            return BuscarIdPorComboBox(combo, "tbl_series", "nome_serie");
        }

        private int BuscarIdPorComboBox(ComboBox combo, string tabela, string campoNome)
        {
            try
            {
                // Pega o nome selecionado no ComboBox
                string nomeSelecionado = combo.Text;

                // Exibe o nome selecionado para depuração
                MessageBox.Show($"Nome selecionado: {nomeSelecionado}");

                if (string.IsNullOrEmpty(nomeSelecionado))
                    return 0;

                // Determina o nome do campo ID de acordo com a tabela
                string nomeId = "";
                if (tabela == "tbl_autores")
                    nomeId = "id_autor";
                else if (tabela == "tbl_generos")
                    nomeId = "id_genero";
                else if (tabela == "tbl_editoras")
                    nomeId = "id_editora";
                else if (tabela == "tbl_series")
                    nomeId = "id_serie";
                else
                {
                    MessageBox.Show("Tabela não reconhecida.");
                    return 0;
                }

                // Cria o SQL
                string sql = $"SELECT {nomeId} FROM {tabela} WHERE {campoNome} = @nome";

                // Exibe o SQL gerado para depuração
                MessageBox.Show($"SQL gerado: {sql}");

                MySqlCommand cmd = new MySqlCommand(sql, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", nomeSelecionado);

                object resultado = cmd.ExecuteScalar();

                // Verifica se o resultado é nulo e exibe o valor encontrado
                if (resultado != null)
                {
                    MessageBox.Show($"ID encontrado: {resultado.ToString()}");
                    return Convert.ToInt32(resultado);
                }
                else
                {
                    MessageBox.Show("ID não encontrado");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                // Exibe qualquer erro ocorrido durante a execução
                MessageBox.Show("Erro ao buscar ID: " + ex.Message);
                return 0;
            }
        }




        private void CadLivros_Load(object sender, EventArgs e)
        {
            //CarregarEditoras();
            CarregarCombos();
            //CarregarGeneros();

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            new FrmLivros();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.titulo = txtNomeLivro.Text;
            Variaveis.IdAutor = cmbAutor.Text;
            Variaveis.IdGenero = cmbGenero.Text;
            Variaveis.anoPub = txtAnoPub.Text;
            Variaveis.preco = txtPreco.Text;
            Variaveis.estoque = txtQuantidade.Text;
            Variaveis.IdEditora = cmbEditora.Text;
            Variaveis.serie = cmbSerie.Text;
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

    }
}


