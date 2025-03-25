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
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            


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
                cmd.Parameters.AddWithValue("@status", "%" + cmbPagamento.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;

                dgvCliente.Columns[0].HeaderText = "ID";
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].Visible = false;
                dgvCliente.Columns[4].Visible = false;
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[6].Visible = false;
                dgvCliente.Columns[7].Visible = false;
                dgvCliente.Columns[8].Visible = false;
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
        private void CarregarNomeLivro()
        {
            try
            {
                Banco.Conectar();

                // Certifique-se de que o parâmetro esteja corretamente formatado com o LIKE
                string selecionar = "SELECT * FROM tbl_livros WHERE titulo_livros LIKE @nomeLivro ORDER BY titulo_livros;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);

                // Aqui, o parâmetro @nomeLivro é formatado para permitir buscas parciais
                cmd.Parameters.AddWithValue("@nomeLivro", "%" + txtNomeLivro.Text + "%"); // Supondo que o nome do livro esteja em um TextBox chamado txtNomeLivro

                // Usar o MySqlDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Vincular o DataTable ao DataGridView
                dgvLivros.DataSource = dt;
                dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Configurar cabeçalhos e ocultar colunas desnecessárias
                dgvLivros.Columns[0].HeaderText = "ID";
                dgvLivros.Columns[1].HeaderText = "TITULO";
                dgvLivros.Columns[2].Visible = false;  // Exemplo: ocultando a terceira coluna
                dgvLivros.Columns[3].Visible = false;
                dgvLivros.Columns[4].Visible = false;
                dgvLivros.Columns[5].HeaderText = "PREÇO";
                dgvLivros.Columns[6].HeaderText = "ESTOQUE";
                dgvLivros.Columns[7].Visible = false; // Ocultando mais uma coluna

                dgvLivros.ClearSelection(); // Limpar seleção de células

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os livros. " + erro.Message);
            }
        }
        private void CarregarNomeCliente()
        {
            try
            {
                Banco.Conectar();

                // Certifique-se de que o parâmetro esteja corretamente formatado com o LIKE
                string selecionar = "SELECT * FROM tbl_cliente WHERE nome_cliente LIKE @nomeCliente ORDER BY nome_cliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);

                // Aqui, o parâmetro @nomeLivro é formatado para permitir buscas parciais
                cmd.Parameters.AddWithValue("@nomeCliente", "%" + txtNomeCliente.Text + "%"); // Supondo que o nome do livro esteja em um TextBox chamado txtNomeLivro

                // Usar o MySqlDataAdapter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Vincular o DataTable ao DataGridView
                dgvCliente.DataSource = dt;
                dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Configurar cabeçalhos e ocultar colunas desnecessárias
                dgvCliente.Columns[0].HeaderText = "ID";
                dgvCliente.Columns[1].HeaderText = "Nome";
                dgvCliente.Columns[2].Visible = false;  // Exemplo: ocultando a terceira coluna
                dgvCliente.Columns[3].Visible = false;
                dgvCliente.Columns[4].Visible = false;
                dgvCliente.Columns[5].HeaderText = "PREÇO";
                dgvCliente.Columns[6].HeaderText = "ESTOQUE";
                

                dgvCliente.ClearSelection(); // Limpar seleção de células
                

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro.Message);
            }
        }




        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void bntSair_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }
        private void InserirVenda()
        {
            try
            {
                Banco.Conectar();

                // Verificar se o id_cliente existe na tabela tbl_clientes
                string verificarCliente = "SELECT COUNT(*) FROM tbl_clientes WHERE id_cliente = @idCliente";
                MySqlCommand cmdVerificar = new MySqlCommand(verificarCliente, Banco.conexao);
                cmdVerificar.Parameters.AddWithValue("@idCliente", Variaveis.idCliente);  // Supondo que idCliente seja uma variável já definida

                int clienteExistente = Convert.ToInt32(cmdVerificar.ExecuteScalar()); // Conta o número de clientes com o id informado

                // Se o cliente não existir, exibe mensagem de erro e retorna
                if (clienteExistente == 0)
                {
                    MessageBox.Show("Cliente não encontrado! Verifique o ID do cliente.");
                    Banco.Desconectar();
                    return;
                }

                // Comando SQL de inserção
                string inserir = "INSERT INTO tbl_vendas (id_cliente, data_venda, valor_total, forma_pagamento) VALUES (@idCliente, @dataCompra, @valorTotal, @forma_pagamento);";

                // Criar o comando MySqlCommand para inserção
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);

                // Adicionar parâmetros ao comando de inserção
                cmd.Parameters.AddWithValue("@idCliente", Variaveis.idCliente);
                cmd.Parameters.AddWithValue("@dataCompra", Variaveis.dataCompra);
                Variaveis.valorTotal = Variaveis.valorTotal / 100; // Ajuste conforme necessário
                cmd.Parameters.AddWithValue("@valorTotal", Variaveis.valorTotal); // Supondo que você tenha a variável valorTotal
                cmd.Parameters.AddWithValue("@forma_pagamento", cmbPagamento.Text);


                // Executar o comando de inserção
                cmd.ExecuteNonQuery();

                // Exibir mensagem de sucesso
                MessageBox.Show("Venda cadastrada com sucesso!");

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar venda: " + erro.Message);
            }
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            InserirVenda();
            Variaveis.idLivro = int.Parse(txtIDLivro.Text);
            Variaveis.idCliente = int.Parse(txtIDCliente.Text);
            Variaveis.valorTotal = decimal.Parse(txtValorTotal.Text);
            Variaveis.dataCompra = DateTime.Parse(dtCompra.Text);




        }

        private void txtNomeLivro_TextChanged(object sender, EventArgs e)
        {
            CarregarNomeLivro();
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            CarregarNomeCliente();
        }
    }


}
