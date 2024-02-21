namespace Exercicio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(10.0);

            Console.WriteLine($"O círculo de raio {circulo.Raio}, possui uma área de {circulo.CalcularArea()}" +
            $" e um perímetro de {circulo.CalcularPerimetro()}.");
        }
    }
}
