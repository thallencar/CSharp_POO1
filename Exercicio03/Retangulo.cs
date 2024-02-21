namespace Exercicio03
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set;}

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalcularArea()
        {
            double area = Altura * Largura;
            return area;
        }

        public double CalcularPerimetro() {
            double perimetro = 2 * (Altura + Largura);
            return perimetro;
        }
    }
}
