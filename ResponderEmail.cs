using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_BooksAndFun
{
    public partial class frmResponderEmail : Form
    {
        int codContato;
        string emailContato, mensagemContato;

        public frmResponderEmail(string email, string mensagem, int id)
        {
            InitializeComponent();
            emailContato = email;
            mensagemContato = mensagem;
            codContato = id;

            txtEmail.Text = emailContato;
            rtbMensagem.Text = mensagemContato;
        }

        public frmResponderEmail()
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }
 
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //Configurar o SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 465);
                smtpClient.Credentials = new System.Net.NetworkCredential("honeymoonspam@gmail.com", "Senac@ti26"); //Email e senha da empresa
                smtpClient.EnableSsl = true;

                //Configurar Email
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("ti26@smpsitema.com.br");
                mailMessage.To.Add(emailContato);
                mailMessage.Subject = txtAssunto.Text;
                mailMessage.Body = rtbResposta.Text;
                mailMessage.IsBodyHtml = false;

                //Enviar Email
                smtpClient.Send(mailMessage);

                AtualizarStatus(codContato);

                MessageBox.Show("E-mail Enviado com sucesso", "Sucesso");

                Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao enviar E-mail.\n" + erro, "Erro");
            }
        }

       

        private void btnResponder_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void frmResponderEmail_Load(object sender, EventArgs e)
        {

        }
        //btnEnviar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblResposta.Visible = true;
            rtbResposta.Visible = true;
            btnEnviar.Visible = true;
            rtbMensagem.Size = new Size(220, 232);

            try
            {
                //Configurar o SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false; // Adicione esta linha
                smtpClient.Credentials = new System.Net.NetworkCredential("honeymoonspam@gmail.com", "svwe utcr aaet jgfg");

                //Configurar Email
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("honeymoonspam@gmail.com");
                mailMessage.To.Add(emailContato);
                mailMessage.Subject = txtAssunto.Text;
                mailMessage.Body = rtbResposta.Text;
                mailMessage.IsBodyHtml = false;

                //Enviar Email
                smtpClient.Send(mailMessage);

                AtualizarStatus(codContato);

                MessageBox.Show("E-mail Enviado com sucesso", "Sucesso");

                Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao enviar E-mail.\n" + erro, "Erro");
            }
        }

        private void AtualizarStatus(int codContato)
        {
            try
            {
                Banco.Conectar();
                string responder = "UPDATE tbl_contato SET status_contato = 'Respondido' WHERE id_contato = @codContato;";
                MySqlCommand cmd = new MySqlCommand(responder, Banco.conexao);
                cmd.Parameters.AddWithValue("@codContato", codContato);
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao responder o Email. \n" + erro);
            }
        }
    }
}

    


