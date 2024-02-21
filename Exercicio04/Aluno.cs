using System.Runtime.Intrinsics.Arm;

namespace Exercicio04
{
    public class Aluno
    {
        public string Nome{ get; set; }
        public int Rm { get; set; }
        public double NotaUm { get; set; }
        public double NotaDois { get; set; }
        public double NotaTres { get; set; }

        public Aluno(string nome, int rm, double notaUm, double notaDois, double notaTres)
        {
            Nome = nome;
            Rm = rm;
            NotaUm = notaUm;
            NotaDois = notaDois;
            NotaTres = notaTres;
        }

        public Aluno(string nome, int rm)
        {
            Nome = nome;
            Rm = rm;
        }

        double media;

        public double CalcularMedia()
        {
            Console.WriteLine("Digite a primeira nota: ");
            NotaUm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            NotaDois = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            NotaTres = double.Parse(Console.ReadLine());

            if (NotaUm >= NotaTres && NotaDois >= NotaTres) {
                media = (NotaUm + NotaDois) / 2;
                Console.WriteLine($"Sua média é de {media}.");
            }
            else if(NotaUm >= NotaDois &&  NotaTres >= NotaDois)
            {
                media = (NotaUm + NotaTres) / 2;

                Console.WriteLine($"Sua média é de {media}.");
            }
            else
            {
                media = (NotaDois + NotaTres) / 2;
                Console.WriteLine($"Sua média é de {media}.");
            }

            return media;
        }
        public void ExibirMedia()
        {
            media = CalcularMedia();

            if (media >= 0 && media <= 3.9)
            {
                Console.WriteLine("Você foi reprovado.");
            }
            else if (media >= 4 && media <= 5.9)
            {
                Console.WriteLine("Você está de recuperação.");
            }
            else if (media >= 6 && media <= 10)
            {
                Console.WriteLine("Você foi aprovado.");
            }
            else
            {
                Console.WriteLine("Erro.");
            }
        }

    }
}
