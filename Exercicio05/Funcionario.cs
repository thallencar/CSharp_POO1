namespace Exercicio05
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public decimal Salario { get; set; }

        public string Cargo { get; set; }

        public Funcionario(string nome, decimal salario, string cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        decimal aliquota;
        public decimal CalcularSalario()
        {
            Salario = decimal.Parse(Console.ReadLine());

            if (Salario <= 2112.00m)
            {
                aliquota = 0;
                Console.WriteLine($"Alíquota isenta. Salário: {Salario}.");
            } else if(Salario >= 2112.01m && Salario <= 2826.65m)
            {
                aliquota = 0.075m;
            } else if (Salario >= 2826.66m && Salario <= 3751.05m)
            {
                aliquota = 0.15m;
            } else if (Salario >= 3751.06m && Salario <= 4664.68m)
            {
                aliquota = 0.225m;
            } else if (Salario > 4664.68m )
            {
                aliquota = 0.275m;
            }else
            {
                Console.WriteLine("Erro. Digite novamente");
            }

            decimal valorDescontado = Salario * aliquota;
            decimal salarioLiquido = Salario - valorDescontado;
            Console.WriteLine($"Alíquota de {aliquota}% aplicada. Salário: R${salarioLiquido}.");

            return Salario;
        }
    }
}
