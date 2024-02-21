namespace Exercicio08
{
    public class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set;}

        public double VelocidadeAtual { get; set; }

        public Carro(string marca, string modelo, double velocidadeAtual)
        {
            Marca = marca;
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
        }

        public void Acelerar()
        {
            if (VelocidadeAtual <= 240)
            {
                VelocidadeAtual += 10;
                Console.WriteLine("Acelerando......");
            }
            else
            {
                Console.WriteLine("Limite máximo de velocidade atingido.");
            }
        }

        public void Frear()
        {
            if (VelocidadeAtual >= 10 && VelocidadeAtual <=250)
            {
                VelocidadeAtual -= 10;
                Console.WriteLine("Freando......");
            }else
            {
                Console.WriteLine("O carro está parado.");
            }
        }
    }
}
