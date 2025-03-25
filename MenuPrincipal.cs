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
    public partial class frmMenuPrincipal : Form
    {
        int codContato;
        string emailContato, mensagemContato;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            dgvContato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvContato.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            


        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timerData.Start();
            CarregarEmail();
        }
        private void CarregarEmail()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_contato WHERE status_contato = 'Aguardando';";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvContato.DataSource = dt;
                dgvContato.Columns[0].Visible = false;
                dgvContato.Columns[1].HeaderText = "NOME";
                dgvContato.Columns[2].HeaderText = "TELEFONE";
                dgvContato.Columns[3].HeaderText = "EMAIL";
                dgvContato.Columns[4].Visible = false;
                dgvContato.Columns[5].HeaderText = "STATUS";
                dgvContato.Columns[6].Visible = false;

                Banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao carregar os emails.\n" + erro);
            }
        }

        private void dgvContato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //verificar a coluna 5 (status)

                if (e.ColumnIndex == 5 && e.Value != null)
                {
                    //analisar se esta aguardando

                    if (e.Value.ToString().Equals("Aguardando", StringComparison.OrdinalIgnoreCase))
                    {

                        e.CellStyle.BackColor = Color.Red;
                    }

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao formatar a cor da celula. \n" + erro);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvContato.Rows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
                emailContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[3].Value).ToString();
                mensagemContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[4].Value).ToString();

                new frmResponderEmail(emailContato, mensagemContato, codContato).ShowDialog(); //Abre o form sobre o anterior

                CarregarEmail(); //Recarregar a lista do Email
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            new frmResponderEmail().Show();
            Hide();
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pctCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvContato.SelectedRows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);

            }   
            ExcluirContato();
            CarregarEmail();
        }
        private void ExcluirContato()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "UPDATE tbl_contato SET status_contato = 'Excluido' WHERE id_contato = @codContato;";

                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codContato", codContato);
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao excluir o Email. \n" + erro);
            }
        }


        private void pctLivros_Click(object sender, EventArgs e)
        {
            
            new FrmLivros().Show();
        }

        private void pctEventos_Click(object sender, EventArgs e)
        {
            new frmEventos().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (dgvContato.Rows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
                emailContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[3].Value).ToString();
                mensagemContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[4].Value).ToString();

                new frmResponderEmail(emailContato, mensagemContato, codContato).ShowDialog(); //Abre o form sobre o anterior

                CarregarEmail(); //Recarregar a lista do Email
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dgvContato.Rows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
                emailContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[3].Value).ToString();
                mensagemContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[4].Value).ToString();

                new frmResponderEmail(emailContato, mensagemContato, codContato).ShowDialog(); //Abre o form sobre o anterior

                CarregarEmail(); //Recarregar a lista do Email
            }
        }

        private void lblApagar_Click(object sender, EventArgs e)
        {
            if (dgvContato.SelectedRows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
                ExcluirContato();
                CarregarEmail();
            }
           
        }

        private void lblResponder_Click(object sender, EventArgs e)
        {
            if (dgvContato.Rows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
                emailContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[3].Value).ToString();
                mensagemContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[4].Value).ToString();

                new frmResponderEmail(emailContato, mensagemContato, codContato).ShowDialog(); //Abre o form sobre o anterior

                CarregarEmail(); //Recarregar a lista do Email
            }

        }

        private void btnResponder_Click_1(object sender, EventArgs e)
        {
            if (dgvContato.Rows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
                emailContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[3].Value).ToString();
                mensagemContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[4].Value).ToString();

                new frmResponderEmail(emailContato, mensagemContato, codContato).ShowDialog(); //Abre o form sobre o anterior

                CarregarEmail(); //Recarregar a lista do Email
            }

        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            if (dgvContato.SelectedRows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);

            }
            ExcluirContato();
            CarregarEmail();
        }


        private void pctServicos_Click(object sender, EventArgs e)
        {
            new frmServicos().Show();
        }

        private void pctVendas_Click(object sender, EventArgs e)
        {
           new Vendas().Show();
        }

        private void pctLivros_Click_1(object sender, EventArgs e)
        {
            new FrmLivros().Show();
        }

        private void pctFuncionarios_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            
        }

        private void pctClientes_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            
        }

        private void pctEventos_Click_1(object sender, EventArgs e)
        {
            new frmEventos().Show();
            
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctFuncionario_Click(object sender, EventArgs e)
        {
            
        }

  

    }
}
