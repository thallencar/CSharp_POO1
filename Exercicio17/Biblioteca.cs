using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Exercicio16
{
    public class Biblioteca
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public decimal Preco { get; set; }
        public string Disponibilidade{ get; set; }

        public Biblioteca(int idLivro, string titulo, string autor, int numeroPaginas, decimal preco, string disponibilidade)
        {
            IdLivro = idLivro;
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Preco = preco;
            Disponibilidade = disponibilidade;
        }

        public Biblioteca()
        {
            
        }

        List<Biblioteca> livros = new List<Biblioteca>();

        public Biblioteca CadastrarLivros()
        {
            Console.WriteLine(@$"CADASTRO DE PRODUTOS");
            Console.WriteLine("IDENTIFICADOR: ");
            IdLivro = int.Parse(Console.ReadLine());

            Console.WriteLine("TÍTULO DO LIVRO: ");
            Titulo = Console.ReadLine();

            Console.WriteLine("AUTOR: ");
            Autor = Console.ReadLine();

            Console.WriteLine("NÚMERO DE PÁGINAS: ");
            NumeroPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine("PREÇO: ");
            Preco = decimal.Parse(Console.ReadLine());

            Disponibilidade = "Disponível";

            return new Biblioteca(IdLivro, Titulo, Autor, NumeroPaginas, Preco, Disponibilidade);
        }

        public void EmprestarLivro()
        {
            if (Disponibilidade == "Disponível")
            {
                Console.WriteLine("Informe o ID do livro");
                IdLivro = int.Parse(Console.ReadLine());
                Console.WriteLine("Livro emprestado");
                Disponibilidade = "Indisponível";
            }

        }

        public void DevolverLivro()
        {
            Console.WriteLine("Informe o ID do livro");
            IdLivro = int.Parse(Console.ReadLine());
            Console.WriteLine("Livro devolvido.");
            Disponibilidade = "Disponível";
        }

        public string VerificaDisponibilidade()
        {
            if (Disponibilidade == "Disponível")
            {
                return $"{Titulo} : Livro disponível";

            }
            else
            {
                return $"{Titulo} : Livro indisponível";
            }

        }


    }
}
