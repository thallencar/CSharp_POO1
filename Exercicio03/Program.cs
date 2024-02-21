namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(5, 10);
            Console.WriteLine($"O retângulo de altura {retangulo.Altura}cm e largura {retangulo.Largura}cm, possui a área de {retangulo.CalcularArea()}cm² e perímetro de {retangulo.CalcularPerimetro()}cm.");
        }
    }
}
