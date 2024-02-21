namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Thalita", 88181);

            Console.WriteLine($@"Aluno(a) {aluno.Nome}, RM{aluno.Rm}.");
            aluno.ExibirMedia();
        }
    }
}
