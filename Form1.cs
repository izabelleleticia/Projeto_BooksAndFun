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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Autenticar();
            new frmMenuPrincipal().Show();
            Hide();
        }
    
     private void Autenticar()
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string pwd = txtSenha.Text.Trim();

                Banco.Conectar();
                string logar = "SELECT email_usuario, senha_usuario, status_usuario FROM tbl_usuarios WHERE email_usuario = @email AND senha_usuario = @pwd;";
                MySqlCommand cmd = new MySqlCommand(logar, Banco.conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                MySqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {

                    while (Dr.Read())
                    {
                        if (Convert.ToString(Dr["status_usuario"]) == "ATIVO")
                        {
                            new frmMenuPrincipal().Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário Inativo!");
                            txtEmail.Focus();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dados incorretos. Tente novamente!");
                    txtEmail.Focus();
                }
                Dr.Close();
                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                {
                    MessageBox.Show("Erro ao consultar o usuário no sistema. " + erro);
                }
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }


}
