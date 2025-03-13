using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_BooksAndFun
{
    public static class Banco   //Criar a string de conexão com o banco de dados    
    {
        //Banco de dados online (Servidor Web)
        public static string db = "SERVER=smpsistema.com.br;USER=u283879542_booksandfun;PASSWORD=@Booksandfun01;DATABASE=u283879542_booksandfun;SSL MODE=None";
        //ESTRUTURA DE CONEXÃO
        public static MySqlConnection conexao;

        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("ERRO AO ACESSAR O BANCO DE DADOS");

            }
        }
        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("ERRO AO DESCONECTAR O BANCO DE DADOS");

            }
        }

    }
}
   
