namespace Exercicio11
{
    public class Pessoa
    {
        public string Nome{ get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public Pessoa(string nome, int idade, string profissao)
        {
            Nome = nome;
            Idade = idade;
            Profissao = profissao;

        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($@"INFORMAÇÕES
Nome: {Nome}
Idade: {Idade}
Profissão: {Profissao}");

        }


        public int CalcularAnoBissexto()
        {
            int anoNascimento = 2024 - Idade;
            int idadeBissexta = 0;

            for (int i = anoNascimento; i <= 2024; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                {
                    idadeBissexta ++;
                }
            }

            return idadeBissexta;
        
        }
    }

}
