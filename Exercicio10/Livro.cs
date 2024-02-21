using System.Reflection.Metadata.Ecma335;

namespace Exercicio10
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo{ get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }

        public string Disponibilidade { get; set; }

        public Livro(int id, string titulo, string autor, int paginas, string disponibilidade)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            Disponibilidade = disponibilidade;
        }

        public Livro() { }

        public void EmprestarLivro()
        {
            if(Disponibilidade == "Disponível")
            {
                Console.WriteLine("Informe o ID do livro");
                Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Livro emprestado");
                Disponibilidade = "Indisponível";
            }else if(Disponibilidade == "Indisponível")
            {
                Console.WriteLine("Livro indisponível no momento");
            }
            
        }

        public void DevolverLivro()
        {
            Console.WriteLine("Informe o ID do livro");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Livro devolvido.");
            Disponibilidade = "Disponível";

            if(Id > 4)
            {
                Console.WriteLine("Digite um valor válido!");
            }
        }

        public string VerificaDisponibilidade()
        {
            if (Disponibilidade == "Disponível")
            {
                return $"{Titulo} : Livro disponível";
                
            }else
            {
                return $"{Titulo} : Livro indisponível";
            }

        }
    }
}
