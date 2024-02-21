namespace Exercicio05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Thalita", 3000.00m, "Desenvolvedora");

            Console.WriteLine($@"FUNCIONÁRIO(A): {funcionario.Nome}
CARGO: {funcionario.Cargo}
SALÁRIO: {funcionario.Salario}");

            funcionario.CalcularSalario();
        }
    }
}
