namespace Exercicio13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine(@"MENU
1 - Adicionar Contato
2 - Remover Contato
3 - Editar Contato
4 - Exibir Contatos

0 - Sair
");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        return;

                    case 1:
                        Console.WriteLine("Nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Número de telefone: ");
                        int numero = int.Parse(Console.ReadLine());
                        agenda.NomeContato = nome;
                        agenda.NumeroTelefone = numero;
                        agenda.AdicionarContato();
                        break;

                    case 2:
                        Console.Write("Nome do contato a ser removido: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContatos(nomeRemover);
                        break;

                    case 3:
                        Console.WriteLine("Nome do contato a ser editado: ");
                        string nomeEditar = Console.ReadLine();
                        agenda.EditarContato(nomeEditar);
                        break;

                    case 4:
                        agenda.ExibirContatos();
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
