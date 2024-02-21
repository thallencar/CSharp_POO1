namespace Exercicio06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto stratocaster = new Produto("Stratocaster", 899.00m, 8);
            Produto telecaster = new Produto("Telecaster", 955.00m, 4);
            Produto lesPaul = new Produto("Les Paul", 1790.00m, 1);
            Produto jaguar = new Produto("Jaguar", 3000.00m, 0);

            while(true)
            {
                Console.WriteLine(@"GUITAR SHOP
1 - PRODUTOS DISPONÍVEIS
2 - ESTOQUE
3 - VALOR EM ESTOQUE

0 - SAIR");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine(@$"PRODUTOS DISPONÍVEIS
GUITARRA - {stratocaster.Nome}
GUITARRA - {telecaster.Nome}
GUITARRA - {lesPaul.Nome}
GUITARRA - {jaguar.Nome}");
                        break;
                    case 2:
                        stratocaster.VerificaDisponibilidade();
                        telecaster.VerificaDisponibilidade();
                        lesPaul.VerificaDisponibilidade();
                        jaguar.VerificaDisponibilidade();
                        break;
                    case 3:
                        stratocaster.CalcularValorTotal();
                        telecaster.CalcularValorTotal();
                        lesPaul.CalcularValorTotal();
                        jaguar.CalcularValorTotal();
                        break;
                    default:
                        Console.WriteLine("Erro! Digite um valor válido.");
                        continue;
                }
            

            }

        }
    }
}
