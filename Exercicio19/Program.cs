namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            JogoAdivinhacao jogoAdivinhacao = new JogoAdivinhacao();
            Console.WriteLine("JOGO NÚMERO SECRETO");
            while (true)
            {
                jogoAdivinhacao.NumeroRandomico();
                jogoAdivinhacao.Adivinhacao();

            }
        }
    }
}
