using Exercicio16;

namespace Exercicio10
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Biblioteca> livro = new List<Biblioteca>();
            Biblioteca hpCaliceDeFogo = new Biblioteca(1, "Harry Potter e o Cálice de Fogo", "J.K Rowling", 480, 119.00m, "Disponível");
            Biblioteca pjoMaldicaoDoTita = new Biblioteca(2, "Percy Jackson e os Olimpianos: A Maldição do Titã", "Rick Riordan", 263, 44.19m, "Indisponível");
            Biblioteca tronoDeVidro = new Biblioteca(3, "Trono de Vidro", "Sarah J. Maas", 328, 50.92m, "Disponível");
            Biblioteca cronicasDeNarnia = new Biblioteca(4, "As Crônicas de Nárnia: O Leão, a Feiticeira e o Guarda-Roupa", "C.S. Lewis", 208, 50.15m, "Indisponível");

            while (true)
            {
                Console.WriteLine(@$"MENU
1 - ESTANTE DE LIVROS
2 - CADASTRAR LIVROS
3 - DISPONIBILIDADE 
4 - RESERVAR
5 - DEVOLVER

0 - SAIR");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 0:
                        return;
                    case 1:
                        Console.WriteLine(@$"ESTANTE DE LIVROS
{hpCaliceDeFogo.Titulo}
{pjoMaldicaoDoTita.Titulo}
{tronoDeVidro.Titulo}
{cronicasDeNarnia.Titulo}
");
                        foreach (var item in livro)
                        {
                            Console.WriteLine($"{item.Titulo}");
                        }
                        break;
                    case 2:
                        Biblioteca novoLivro = new Biblioteca();
                        livro.Add(novoLivro.CadastrarLivros());
                        break;
                    case 3:
                        Console.WriteLine("Informe o ID do livro");
                        int idLivro = int.Parse(Console.ReadLine());

                        switch (idLivro)
                        {
                            case 1:
                                Console.WriteLine(hpCaliceDeFogo.VerificaDisponibilidade());
                                break;
                            case 2:
                                Console.WriteLine(pjoMaldicaoDoTita.VerificaDisponibilidade());
                                break;
                            case 3:
                                Console.WriteLine(tronoDeVidro.VerificaDisponibilidade());
                                break;
                            case 4:
                                Console.WriteLine(cronicasDeNarnia.VerificaDisponibilidade());
                                break;
                            default:
                                Console.WriteLine("Livro não encontrado.");
                                break;
                        }
                        break;
                    case 4:
                        hpCaliceDeFogo.EmprestarLivro();
                        break;
                    case 5:
                        hpCaliceDeFogo.DevolverLivro();

                        break;
                    default:
                        Console.WriteLine("Erro! Digite uma opção válida.");
                        continue;
                }

            }
        }
    }
}
