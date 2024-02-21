namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Consulta> consultas = new List<Consulta>();
            Paciente paciente = new Paciente("Thalita", 18, consultas);

            while (true)
            {
                Console.WriteLine(@$"MENU
1 - INFORMAÇÕES DO PERFIL
2 - NOVA CONSULTA
3 - HISTÓRICO DE CONSULTAS

0 - SAIR");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 0:
                        return;
                    case 1:
                        Console.WriteLine(@$"INFORMAÇÕES DO PERFIL
Nome: {paciente.Nome}
Idade: {paciente.Idade}
");
                        break;
                    case 2:
                        Console.WriteLine("NOVA CONSULTA");
                        Consulta novaConsulta = new Consulta();
                        novaConsulta.CriarNovaConsulta();
                        paciente.NovaConsulta(novaConsulta);
                        break;
                    case 3:
                        paciente.HistoricoConsulta();
                        break;
                    default:
                        Console.WriteLine("Erro! Digite uma opção válida.");
                        continue;
                }

            }
        }


    }
}
