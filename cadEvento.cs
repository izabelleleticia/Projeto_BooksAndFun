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
using Org.BouncyCastle.Asn1.Cmp;
using static Projeto_BooksAndFun.frmCadastroCliente;

namespace Projeto_BooksAndFun
{
    public partial class frmCadEvento : Form
    {
        public frmCadEvento()
        {
            InitializeComponent();
            dtInicio.Format = DateTimePickerFormat.Custom;
            dtInicio.CustomFormat = "dd/MM/yyyy HH:mm"; // Formato dia/mês/ano hora:minuto
            dtInicio.ShowUpDown = true; // Remove o calendário e permite ajustar manualmente
            dtFim.Format = DateTimePickerFormat.Custom;
            dtFim.CustomFormat = "dd/MM/yyyy HH:mm"; // Formato dia/mês/ano hora:minuto
            dtFim.ShowUpDown = true; // Remove o calendário e permite ajustar manualmente

        }


        private void CadastrarEvento()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO tbl_eventos (nome_evento, descricao_evento, data_hora_inicio, data_hora_fim, local_evento, status_evento) " +
                                 "VALUES (@nome, @descricao, @data_inicio, @data_fim, @local, @status);";

                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);

                // Verifica se as variáveis não são nulas antes de usá-las
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeEvento ?? "Nome não informado");
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descricaoEvento ?? string.Empty);

                // Converte DateTime para string no formato correto antes de inserir
                cmd.Parameters.AddWithValue("@data_inicio", dtInicio.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@data_fim",dtFim.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@local", Variaveis.localEvento ?? string.Empty);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusEvento ?? "ATIVO"); // Definir padrão ATIVO caso esteja vazio

                cmd.ExecuteNonQuery();  
                MessageBox.Show("Evento cadastrado com sucesso!", "Cadastro");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar evento: {erro.Message}", "Erro");
            }
            finally
            {
                Banco.Desconectar();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.nomeEvento = txtNomeEvento.Text;
            Variaveis.descricaoEvento = txtDescricao.Text;
            Variaveis.dataInicioEvento = dtInicio.Text;
            Variaveis.dataFimEvento = dtFim.Text;
            Variaveis.localEvento = txtLocal.Text;
            Variaveis.statusEvento = cmbStatus.Text;

            CadastrarEvento();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "ALTERAR";
            new frmAlterarEvento().Show();
        }

      
    }
}   
