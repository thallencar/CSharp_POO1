namespace Exercicio10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            Livro hpCaliceDeFogo = new Livro(1, "Harry Potter e o Cálice de Fogo", "J.K Rowling", 480, "Disponível");
            Livro pjoMaldicaoDoTita = new Livro(2, "Percy Jackson e os Olimpianos: A Maldição do Titã", "Rick Riordan", 263, "Indisponível");
            Livro tronoDeVidro = new Livro(3, "Trono de Vidro", "Sarah J. Maas", 328, "Disponível");
            Livro cronicasDeNarnia = new Livro(4, "As Crônicas de Nárnia: O Leão, a Feiticeira e o Guarda-Roupa", "C.S. Lewis", 208, "Indisponível");

            while (true)
            {
                Console.WriteLine(@$"MENU
1 - ESTANTE DE LIVROS
2 - DISPONIBILIDADE 
3 - RESERVAR
4 - DEVOLVER

0 - SAIR");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 0:
                        return;
                    case 1:
                        Console.WriteLine(@$"ESTANTE DE LIVROS
{hpCaliceDeFogo.Id} - {hpCaliceDeFogo.Titulo}
{pjoMaldicaoDoTita.Id} - {pjoMaldicaoDoTita.Titulo}
{tronoDeVidro.Id} - {tronoDeVidro.Titulo}
{cronicasDeNarnia.Id} - {cronicasDeNarnia.Titulo}
");
                        break;
                    case 2:
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
                    case 3:
                        hpCaliceDeFogo.EmprestarLivro();
                        break;
                    case 4:
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
