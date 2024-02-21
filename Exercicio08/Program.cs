namespace Exercicio08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Hyundai", "HB20", 0);

            
            while (true)
            {
                Console.WriteLine(@$"MENU
1 - INFORMAÇÕES DO CARRO
2 - ACELERAR
3 - FREAR

0 - SAIR");      
                int option = int.Parse(Console.ReadLine());

                switch (option) {

                    case 0:
                        return;
                    case 1:
                        Console.WriteLine(@$"INFORMAÇÕES DO CARRO
Modelo: {carro.Modelo}
Marca: {carro.Marca}
Velocidade Atual: {carro.VelocidadeAtual}Km/h");
                        break;
                    case 2:
                        carro.Acelerar();
                        break;
                    case 3:
                        carro.Frear();
                        break;
                    default:
                        Console.WriteLine("Erro! Digite uma opção válida.");
                        continue;
                }
      
            }
        }
    }
}
