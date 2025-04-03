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

      
        private void bntSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            lblResposta.Visible = true;
            rtbResposta.Visible = true;



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




