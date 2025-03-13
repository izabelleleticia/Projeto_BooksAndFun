using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_BooksAndFun
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMenuPrincipal().Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadEvento().Show();
        }
    }
}
