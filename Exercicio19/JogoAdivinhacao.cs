namespace Exercicio19
{
    public class JogoAdivinhacao
    {
        public int NumeroSecreto { get; set; }
        public int Chute { get; set; }

        public JogoAdivinhacao(int numeroSecreto, int chute)
        {
            NumeroSecreto = numeroSecreto;
            Chute = chute;
        }

        public JogoAdivinhacao()
        {
            
        }

        public void NumeroRandomico() { 
            Random random = new Random();
            NumeroSecreto = random.Next(0, 11);   
        }

        public void Adivinhacao()
        {
            while (true)
            {
                int palpite = int.Parse(Console.ReadLine());
                if (palpite < NumeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior.");

                }
                else if (palpite > NumeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor.");

                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto!");
                    break;
                }

            }
           
        }
    }

}
