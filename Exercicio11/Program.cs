namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Thalita", 18, "Estudante");

            while (true)
            {
                Console.WriteLine(@"MENU
1 - CALCULADORA DE IDADE BISSEXTA
2 - INFORMAÇÕES 
0 - SAIR");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("CALCULAR IDADE EM ANOS BISSEXTOS");
                        int idadeBissexta = pessoa.CalcularAnoBissexto();
                        Console.WriteLine($"Idade em anos bissextos: {idadeBissexta}");
                        break;
                    case 2:
                        pessoa.ExibirInformacoes();
                        break;
                    default:
                        Console.WriteLine("Erro! Digite um valor válido.");
                        break;
                }
            }
        }
    }
}
