using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BooksAndFun
{
    public static class Variaveis
    {
        //Geral
        public static string funcao; //criação de varíavel
        public static int linhaSelecionada;


        //Servico
        public static int codServico;
        public static string nomeServico, descricaoServico, fotoServico, caminhoFotoServico, atFotoServico, altServico, tipoServico, statusServico;
        public static double valorServico;
        public static DateTime duracaoServico;

        //Especialidade
        public static int codEspecialidade;
        public static string nomeEspecialidade;

        //Cliente
        public static int codCliente;
        public static string nomeCliente, cpfCliente, enderecoCliente, cidadeCliente, bairroCliente, telefoneCliente, senhaCliente, emailCliente, statusCliente, estadoCliente;
        public static DateTime dataCadCliente;

        //Evento
        public static string dataInicioEvento, dataFimEvento, descricaoEvento, nomeEvento, localEvento, statusEvento;
        public static string idEventoSelecionado;

        //Vendas
        public static int idCliente, idLivro;
        public static DateTime dataCompra;
        public static decimal valorTotal;

        //Livros
        public static string nomeLivro;

        //Cadastrar Livros
        public static string titulo, IdAutor, IdGenero, anoPub, preco, estoque, IdEditora;


        //FTP
        public static string enderecoServidorFtp = "ftp://127.0.0.1/";
        public static string usuarioFtp = "ti26";
        public static string senhaFtp = "123";






    }

}
