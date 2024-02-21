namespace Exercicio07
{
    public class Triangulo
    {
        public double LadoA {  get; set; }

        public double LadoB { get; set;}

        public double LadoC { get; set;}

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }


        public double CalcularTriangulo()
        {
            if(LadoA == LadoB)
            {
                double area = (LadoA * LadoC) / 2;
                Console.WriteLine($"A área do triângulo é de {area}cm²");
                return area;
            }
            else
            {
                Console.WriteLine("Os lados A e B devem ser iguais.");
                return 0; 
            }
        }
    }
}
