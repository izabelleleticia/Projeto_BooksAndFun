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
    public partial class frmCadEvento : Form
    {
        public frmCadEvento()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = mtEvento.SelectionStart;
            MessageBox.Show("Você selecionou: " + dataSelecionada.ToShortDateString());
        }
    }
}
