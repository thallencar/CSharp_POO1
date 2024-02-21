namespace Exercicio01
{
    public class Circulo
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        const double pi = 3.14;

        public double CalcularArea()
        {
            double area = pi * (Raio * Raio);
            return area;
        }

        public double CalcularPerimetro() 
        {
            double perimetro = 2 * pi * Raio;
            return perimetro;
        }

    
    }

    
}
