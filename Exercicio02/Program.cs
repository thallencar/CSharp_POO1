namespace Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria(8001, "Thalita", 4000.00m);


            while (true)
            {
                Console.WriteLine(@"MENU:
    1 - DADOS DA CONTA
    2 - SALDO DA CONTA
    3 - DEPÓSITO
    4 - SAQUE

    0 - SAIR");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        break;
                    case "1":
                        Console.WriteLine(@$"
NÚMERO DA CONTA: {contaBancaria.NumeroConta}
NOME: {contaBancaria.NomeTitular}
SALDO DISPONÍVEL: {contaBancaria.SaldoConta}");
                        break;
                    case "2":
                        Console.WriteLine($"O saldo atual da conta {contaBancaria.SaldoConta}");
                        break;
                    case "3":
                        Console.WriteLine(contaBancaria.DepositoBancario());
                        break;
                    case "4":
                        Console.WriteLine(contaBancaria.SaqueBancario());
                        break;
                    default:
                        Console.WriteLine("Erro. Digite uma opção válida!");
                        option = Console.ReadLine();
                        break;

                }

                Console.WriteLine(@"
    Deseja continuar no programa?
                       
    1 - SIM
    2 - NÃO
                    ");

                string loopContinuation = Console.ReadLine();

                if (loopContinuation == "1")
                {
                    continue;
                }
                else if (loopContinuation == "2")
                {
                    Console.WriteLine("Programa finalizado.");
                    break;
                } else
                {
                    Console.WriteLine("Número inválido.");
                    continue;
                }
            }
        }
    }
}
