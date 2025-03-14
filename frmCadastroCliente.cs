using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Pkcs;
using Projeto_BooksAndFun;
using static System.Net.WebRequestMethods;
using BCrypt.Net;

namespace Projeto_BooksAndFun
{

    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        //Estrutura de validação FTP
        private bool ValidarFtp()
        {
            if (string.IsNullOrEmpty(Variaveis.enderecoServidorFtp) ||
                string.IsNullOrEmpty(Variaveis.usuarioFtp) ||
                string.IsNullOrEmpty(Variaveis.senhaFtp))
            {
                return false;//Se tudo estiver vazio ele para a execução
            }
            else
            {
                return true;
            }
        }

        public class SenhaHelper
        {
            // Método para gerar o hash da senha
            public static string HashSenha(string senha)
            {
                return BCrypt.Net.BCrypt.HashPassword(senha);
            }

            // Método para verificar se a senha digitada corresponde ao hash armazenado
            public static bool VerificarSenha(string senhaDigitada, string senhaHash)
            {
                return BCrypt.Net.BCrypt.Verify(senhaDigitada, senhaHash);
            }
        }

        //Estrutura de validação FTP
        //private bool ValidarFtp()
        //{
        //    if (string.IsNullOrEmpty(Variaveis.enderecoServidorFtp) ||
        //        string.IsNullOrEmpty(Variaveis.usuarioFtp) ||
        //        string.IsNullOrEmpty(Variaveis.senhaFtp))
        //    {
        //        return false;//Se tudo estiver vazio ele para a execução
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}


        //eSTRUTURA DE CONVER~SAO IMG ARA BYTE
        //public byte[] GetImgToByte(string caminhoArquivoFtp)
        //{
        //    WebClient ftpClient = new WebClient();
        //    ftpClient.Credentials = new NetworkCredential(Variaveis.usuarioFtp, Variaveis.senhaFtp);
        //    byte[] imageToByte = ftpClient.DownloadData(caminhoArquivoFtp);
        //    return imageToByte;
        //}

        ////Estrutura de conversão de byte para img
        //private static Bitmap ByteToImage(byte[] blob)
        //{
        //    MemoryStream memoryStream = new MemoryStream();
        //    byte[] pData = blob;
        //    memoryStream.Write(pData, 0, Convert.ToInt32(pData.Length));
        //    Bitmap bmp = new Bitmap(memoryStream, false);
        //    memoryStream.Dispose();
        //    return bmp;
        //}
        private void CadastrarCliente()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO tbl_cliente (nome_cliente, cpf_cliente, endereco_cliente, bairro_cliente, cidade_cliente, estado_cliente, telefone_cliente, email_cliente, senha_cliente, data_cad, status_cliente) " +
                                 "VALUES (@nome, @cpf, @endereco, @bairro, @cidade, @estado, @telefone, @email, @senha, @data_cad, @status);";

                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);


                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente ?? "Nome não informado");
                cmd.Parameters.AddWithValue("@cpf", Variaveis.cpfCliente ?? string.Empty);
                cmd.Parameters.AddWithValue("@endereco", Variaveis.enderecoCliente ?? string.Empty);
                cmd.Parameters.AddWithValue("@bairro", Variaveis.bairroCliente ?? string.Empty);
                cmd.Parameters.AddWithValue("@cidade", Variaveis.cidadeCliente ?? string.Empty);
                cmd.Parameters.AddWithValue("@estado", Variaveis.estadoCliente ?? string.Empty);
                cmd.Parameters.AddWithValue("@telefone", Variaveis.telefoneCliente ?? string.Empty);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailCliente ?? string.Empty);
                string senhaCriptografada = SenhaHelper.HashSenha(Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@senha", senhaCriptografada);


                if (Variaveis.dataCadCliente == DateTime.MinValue)
                {
                    Variaveis.dataCadCliente = DateTime.Now;
                }
                cmd.Parameters.AddWithValue("@data_cad", Variaveis.dataCadCliente);


                cmd.Parameters.AddWithValue("@status", Variaveis.statusCliente ?? "ATIVO");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {erro.Message}", "Erro");
            }
            finally
            {
                Banco.Desconectar();
            }
        }
        private void AlterarCliente()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE tbl_servico SET nome_servico = @nome, descricao_servico = @descricao, valor_servico = @valor, tempo_exec_servico = @duracao, alt_tipo = @alt, tipo_servico = @tipo, id_especialidade = @codEspecialidade, status_servico = @status WHERE id_servico = @codigo;";

                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeServico);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descricaoServico);
                cmd.Parameters.AddWithValue("@valor", Variaveis.valorServico);
                cmd.Parameters.AddWithValue("@duracao", Variaveis.duracaoServico.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@alt", Variaveis.altServico);
                cmd.Parameters.AddWithValue("@tipo", Variaveis.tipoServico);
                cmd.Parameters.AddWithValue("@codEspecialidade", Variaveis.codEspecialidade);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusServico);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
                cmd.ExecuteNonQuery();
                if (Variaveis.dataCadCliente == DateTime.MinValue)
                {
                    Variaveis.dataCadCliente = DateTime.Now; // Define a data atual, se necessário
                }
                cmd.Parameters.AddWithValue("@data_cad", Variaveis.dataCadCliente.ToString("yyyy-MM-dd HH:mm:ss"));
                MessageBox.Show("Serviço alterado com sucesso!", "ALTERAR SERVIÇO");

                Banco.Desconectar();

                //Estrutura para FOTO



            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao alterar SERVIÇO!\n\n" + erro, "ERRO");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.White;
            lblCPF.ForeColor = Color.White;
            lblCidade.ForeColor = Color.White;
            lblEstado.ForeColor = Color.White;
            lblEndereco.ForeColor = Color.White;
            lblBairro.ForeColor = Color.White;
            lblEmail.ForeColor = Color.White;
            lblTelefone.ForeColor = Color.White;
            lblDataCad.ForeColor = Color.White;
            lblStatus.ForeColor = Color.White;

            if (txtNome.Text.Length == 0)
            {
                lblNome.ForeColor = Color.Red;
                MessageBox.Show("Preencha o nome");
                txtNome.Focus();
            }
            else if (txtCPF.Text.Length == 0)
            {
                lblCPF.ForeColor = Color.Red;
                MessageBox.Show("Preencha a descrição");
            }
            else if (txtCidade.Text.Length == 0)
            {
                lblCidade.ForeColor = Color.Red;
                MessageBox.Show("Preencha o valor");
                txtCidade.Focus();
            }
            else if (txtEstado.Text.Length == 0)
            {
                lblEstado.ForeColor = Color.Red;
                MessageBox.Show("Preencha o valor");
                txtEstado.Focus();
            }

            else if (txtEndereco.Text.Length == 0)
            {
                lblEndereco.ForeColor = Color.Red;
                MessageBox.Show("Preencha o tipo");
            }
            else if (txtBairro.Text.Length == 0)
            {
                lblBairro.ForeColor = Color.Red;
                MessageBox.Show("Preencha a especialidade");
                txtBairro.Focus();

            }
            else if (txtEmail.Text.Length == 0)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Preencha a especialidade");
                txtEmail.Focus();

            }
            else if (txtTelefone.Text.Length == 0)
            {
                lblTelefone.ForeColor = Color.Red;
                MessageBox.Show("Preencha a especialidade");
                txtTelefone.Focus();
            }
            else if (mkdData.Text.Length == 0)
            {
                lblDataCad.ForeColor = Color.Red;
                MessageBox.Show("Preencha a especialidade");
                mkdData.Focus();
            }
            else
            {
                Variaveis.nomeCliente = txtNome.Text;
                Variaveis.cpfCliente = txtCPF.Text;
                Variaveis.cidadeCliente = txtCidade.Text;
                Variaveis.estadoCliente = txtEstado.Text;
                Variaveis.enderecoCliente = txtEndereco.Text;
                Variaveis.bairroCliente = txtBairro.Text;
                Variaveis.emailCliente = txtEmail.Text;
                Variaveis.telefoneCliente = txtTelefone.Text;
                Variaveis.senhaCliente = txtSenha.Text;

                Variaveis.statusServico = cmbStatus.Text;


                if (Variaveis.funcao == "CADASTRAR")
                {
                    CadastrarCliente();
                    Variaveis.funcao = "";
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarCliente();
                    if (Variaveis.atFotoServico == "S")
                    {
                        AlterarFotoCliente();
                    }
                }
            }
        }

        private void AlterarFotoCliente()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE tbl_servico SET foto_servico = @foto WHERE id_servico = @codigo;";

                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@foto", Variaveis.fotoServico);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço alterado com sucesso!", "ALTERAR SERVIÇO");
                Banco.Desconectar();

                //Estrutura para FOTO
                if (ValidarFtp())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoServico))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "servico/" + Path.GetFileName(Variaveis.fotoServico);
                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoServico, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch
                        {
                            MessageBox.Show("Foto não selecionada ou foto já existente!");
                        }
                    }
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao alterar SERVIÇO!\n\n" + erro, "ERRO");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            new frmCadastroCliente().Show();
        }
    }
}


//O ideal para a ComboBox é deixar o status fixos, inseridos manualmente e não puxar do banco
//private void CarregarStatusCliente()
//{
//    try
//    {
//        Banco.Conectar();
//        string selecionar = "SELECT status_cliente from tbl_cliente;";
//        MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
//        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//        DataTable dt = new DataTable();
//        da.Fill(dt);
//        cmbStatus.DataSource = dt;
//        cmbStatus.DisplayMember = "status_cliente";
//        cmbStatus.SelectedIndex = -1;

//        Banco.Desconectar();
//    }
//    catch (Exception erro)
//    {

//        MessageBox.Show("Erro ao carregar as especialidades. " + erro);
//    }
//}






//private void frmCadastroCliente_Load(object sender, EventArgs e)
//{
//    CarregarStatusCliente();
//}


//Estrutura para FOTO
//        if (ValidarFtp())
//        {
//            if (!string.IsNullOrEmpty(Variaveis.fotoServico))
//            {
//                string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "servico/" + Path.GetFileName(Variaveis.fotoServico);

//                try
//                {
//                    ftp.EnviarArquivoFtp(Variaveis.caminhoFotoServico, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);

//                }
//                catch (Exception erro)
//                {

//                    MessageBox.Show("Foto não selecionada ou foto já existente!" + erro);
//                }
//            }
//        }


//    }
//    catch (Exception erro)
//    {

//        MessageBox.Show("Erro ao cadastrar SERVIÇO!\n\n" + erro, "ERRO");
//    }
//}
//private void AlterarServico()
//{
//    try
//    {
//        Banco.Conectar();
//        string alterar = "UPDATE tbl_servico SET nome_servico = @nome, descricao_servico = @descricao, valor_servico = @valor, tempo_exec_servico = @duracao, alt_tipo = @alt, tipo_servico = @tipo, id_especialidade = @codEspecialidade, status_servico = @status WHERE id_servico = @codigo;";

//        MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
//        cmd.Parameters.AddWithValue("@nome", Variaveis.nomeServico);
//        cmd.Parameters.AddWithValue("@descricao", Variaveis.descricaoServico);
//        cmd.Parameters.AddWithValue("@valor", Variaveis.valorServico);
//        cmd.Parameters.AddWithValue("@duracao", Variaveis.duracaoServico.ToString("HH:mm"));
//        cmd.Parameters.AddWithValue("@alt", Variaveis.altServico);
//        cmd.Parameters.AddWithValue("@tipo", Variaveis.tipoServico);
//        cmd.Parameters.AddWithValue("@codEspecialidade", Variaveis.codEspecialidade);
//        cmd.Parameters.AddWithValue("@status", Variaveis.statusServico);
//        cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
//        cmd.ExecuteNonQuery();
//        MessageBox.Show("Serviço alterado com sucesso!", "ALTERAR SERVIÇO");
//        Banco.Desconectar();

//        //Estrutura para FOTO



//    }
//    catch (Exception erro)
//    {

//        MessageBox.Show("Erro ao alterar SERVIÇO!\n\n" + erro, "ERRO");
//    }
//}
//private void AlterarFotoServico()
//{
//    try
//    {
//        Banco.Conectar();
//        string alterar = "UPDATE tbl_servico SET foto_servico = @foto WHERE id_servico = @codigo;";

//        MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
//        cmd.Parameters.AddWithValue("@foto", Variaveis.fotoServico);
//        cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
//        cmd.ExecuteNonQuery();
//        MessageBox.Show("Serviço alterado com sucesso!", "ALTERAR SERVIÇO");
//        Banco.Desconectar();

//        //Estrutura para FOTO
//        if (ValidarFtp())
//        {
//            if (!string.IsNullOrEmpty(Variaveis.fotoServico))
//            {
//                string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "servico/" + Path.GetFileName(Variaveis.fotoServico);
//                try
//                {
//                    ftp.EnviarArquivoFtp(Variaveis.caminhoFotoServico, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
//                }
//                catch
//                {
//                    MessageBox.Show("Foto não selecionada ou foto já existente!");
//                }
//            }
//        }
//    }
//    catch (Exception erro)
//    {

//        MessageBox.Show("Erro ao alterar SERVIÇO!\n\n" + erro, "ERRO");
//    }
//}

//private void CarregarDadosServico()
//{
//    try
//    {
//        Banco.Conectar();
//        string selecionar = "SELECT id_servico, nome_servico, descricao_servico, valor_servico, tempo_exec_servico, alt_tipo, tipo_servico, nome_especialidade, status_servico, foto_servico FROM tbl_servico s INNER JOIN tbl_especialidade e ON s.id_especialidade = e.id_especialidade WHERE id_servico = @codigo;";
//        MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
//        cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
//        MySqlDataReader dr = cmd.ExecuteReader();
//        if (dr.Read())
//        {

//            Variaveis.nomeServico = dr.GetString(1);
//            Variaveis.descricaoServico = dr.GetString(2);
//            Variaveis.valorServico = dr.GetDouble(3);
//            //Variaveis.duracaoServico = dr.GetDateTime(4);
//            Variaveis.altServico = dr.GetString(5);
//            Variaveis.tipoServico = dr.GetString(6);
//            Variaveis.nomeEspecialidade = dr.GetString(7);
//            Variaveis.statusServico = dr.GetString(8);
//            Variaveis.fotoServico = dr.GetString(9);
//            Variaveis.fotoServico = Variaveis.fotoServico.Remove(0, 8);
//            pctServico.Image = ByteToImage(GetImgToByte(Variaveis.enderecoServidorFtp + "servico/" + Variaveis.fotoServico));

//            txtNome.Text = Variaveis.nomeServico;
//            txtDescricao.Text = Variaveis.descricaoServico;
//            txtValor.Text = Variaveis.valorServico.ToString();
//            //mkdDuracao.Text = Variaveis.duracaoServico.ToString();
//            txtTipo.Text = Variaveis.tipoServico.ToString();
//            cmbEspecialidade.Text = Variaveis.nomeEspecialidade;
//            cmbStatus.Text = Variaveis.statusServico;
//            try
//            {
//                pctServico.Image = ByteToImage(GetImgToByte(Variaveis.enderecoServidorFtp + "servico/" + Variaveis.fotoServico));
//            }
//            catch
//            {
//                pctServico.Image = ByteToImage(GetImgToByte(Variaveis.enderecoServidorFtp + "servico/semfoto.png"));
//            }
//        }
//    }
//    catch (Exception erro)
//    {

//        MessageBox.Show("Não foi possível carregar os dados do serviço " + erro, "ERRO CARREGAR DADOS");
//    }
//}




//private void CarregarEspecialidade()
//{
//    try
//    {
//        Banco.Conectar();
//        string selecionar = "SELECT id_especialidade, nome_especialidade FROM tbl_especialidade ORDER BY nome_especialidade;";
//        MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
//        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
//        DataTable dt = new DataTable();
//        da.Fill(dt);
//        cmbEspecialidade.DataSource = dt;
//        cmbEspecialidade.DisplayMember = "nome_especialidade";
//        cmbEspecialidade.ValueMember = "id_especialidade";
//        cmbEspecialidade.SelectedIndex = -1;

//        Banco.Desconectar();
//    }
//    catch (Exception erro)
//    {

//        MessageBox.Show("Erro ao carregar as especialidades. " + erro);
//    }
//}
//private void btnSair_Click(object sender, EventArgs e)
//{
//    new frmServico().Show();
//    Hide();
//}
//private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
//{
//    if (e.KeyChar == (char)Keys.Enter)
//    {
//        txtDescricao.Focus();
//    }
//}

//private void btnLimpar_Click(object sender, EventArgs e)
//{
//    txtNome.Clear();
//    txtDescricao.Clear();
//    txtValor.Clear();
//    txtTipo.Clear();
//    mkdDuracao.Clear();

//}



//private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
//{
//    if (e.KeyChar == (char)Keys.Enter)
//    {
//        btnSalvar.Focus();
//    }
//}

//private void btnSalvar_Click(object sender, EventArgs e)
//{
//    lblNome.ForeColor = Color.White;
//    lblDescricao.ForeColor = Color.White;
//    lblValor.ForeColor = Color.White;
//    lblTipo.ForeColor = Color.White;
//    lblEspecialidade.ForeColor = Color.White;
//    lblStatus.ForeColor = Color.White;

//    if (txtNome.Text.Length == 0)
//    {
//        lblNome.ForeColor = Color.Red;
//        MessageBox.Show("Preencha o nome");
//        txtNome.Focus();
//    }
//    else if (txtDescricao.Text.Length == 0)
//    {
//        lblDescricao.ForeColor = Color.Red;
//        MessageBox.Show("Preencha a descrição");
//    }
//    else if (txtValor.Text.Length == 0)
//    {
//        lblValor.ForeColor = Color.Red;
//        MessageBox.Show("Preencha o valor");
//        txtValor.Focus();
//    }
//    else if (mkdDuracao.MaskCompleted == false)
//    {
//        lblDuracao.ForeColor = Color.Red;
//        MessageBox.Show("Preencha a duração");
//        mkdDuracao.Focus();
//    }

//    else if (txtTipo.Text.Length == 0)
//    {
//        lblTipo.ForeColor = Color.Red;
//        MessageBox.Show("Preencha o tipo");
//    }
//    else if (cmbEspecialidade.Text.Length == 0)
//    {
//        lblEspecialidade.ForeColor = Color.Red;
//        MessageBox.Show("Preencha a especialidade");
//        cmbEspecialidade.Focus();
//    }
//    else if (cmbStatus.Text.Length == 0)
//    {
//        lblStatus.ForeColor = Color.Red;
//        MessageBox.Show("Preencha o status");
//        cmbStatus.Focus();
//    }
//    else
//    {
//        Variaveis.nomeServico = txtNome.Text;
//        Variaveis.descricaoServico = txtDescricao.Text;
//        Variaveis.valorServico = double.Parse(txtValor.Text);
//        Variaveis.duracaoServico = DateTime.Parse(mkdDuracao.Text);
//        Variaveis.altServico = txtNome.Text.ToLower();
//        Variaveis.tipoServico = txtTipo.Text;
//        Variaveis.codEspecialidade = Convert.ToInt32(cmbEspecialidade.SelectedValue);
//        Variaveis.statusServico = cmbStatus.Text;

//        if (Variaveis.funcao == "CADASTRAR")
//        {
//            InserirServico();
//            Variaveis.funcao = "";
//        }
//        else if (Variaveis.funcao == "ALTERAR")
//        {
//            AlterarServico();
//            if (Variaveis.atFotoServico == "S")
//            {
//                AlterarFotoServico();
//            }
//        }
//    }
//}
//private void CadServico_Load(object sender, EventArgs e)
//{
//    lblFuncao.Text = Variaveis.funcao;
//    CarregarEspecialidade();
//    if (Variaveis.funcao == "ALTERAR")
//    {
//        CarregarDadosServico();
//    }
//}

//private void btnAdcFoto_Click(object sender, EventArgs e)
//{
//    try
//    {
//        OpenFileDialog ofd = new OpenFileDialog();
//        ofd.Multiselect = false;
//        ofd.FileName = "";
//        ofd.InitialDirectory = @"C:";
//        ofd.Title = "SELECIONE UMA FOTO";
//        ofd.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg;*.png";
//        ofd.CheckFileExists = true;
//        ofd.CheckPathExists = true;
//        ofd.RestoreDirectory = true;

//        DialogResult dr = ofd.ShowDialog();
//        pctServico.Image = Image.FromFile(ofd.FileName);
//        Variaveis.fotoServico = "servico/" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + Regex.Replace(txtNome.Text, @"\s", "_").ToLower() + ".png";


//        if (dr == DialogResult.OK)
//        {

//            try
//            {
//                Variaveis.atFotoServico = "S";
//                Variaveis.caminhoFotoServico = ofd.FileName;

//            }
//            catch (SecurityException erro)
//            {

//                MessageBox.Show("Erro de segurança, fale com o ADMIN. \n" + erro.Message + "\nDetalhe:\n" + erro.StackTrace);
//            }
//            catch (Exception erro)
//            {
//                MessageBox.Show("Você não tem permissão para imagens" + erro);
//            }
//        }
//        btnSalvar.Focus();

//    }
//    catch
//    {
//        btnSalvar.Focus();

//    }