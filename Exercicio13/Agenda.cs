namespace Exercicio13
{
    public class Agenda
    {
        public string NomeContato { get; set; }
        public int NumeroTelefone { get; set; }

        List<Agenda> contatos = new List<Agenda>();
        
        public Agenda(string nomeContato, int numeroTelefone)
        {
            NomeContato = nomeContato;
            NumeroTelefone = numeroTelefone;
        }

        public Agenda()
        {
            
        }
        
        
        public void AdicionarContato()
        {
            Agenda novoContato = new Agenda(NomeContato, NumeroTelefone);
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado.");
        }

        public void RemoverContatos(string nome)
        {
            bool contatoRemovido = false;
            for (int i = 0; i < contatos.Count; i++)
            {
                if (contatos[i].NomeContato == nome)
                {
                    contatos.RemoveAt(i);
                    Console.WriteLine("Contato removido.");
                    contatoRemovido = true;
                    break; 
                }
            }
            if (!contatoRemovido)
            {
                Console.WriteLine("Contato não encontrado");
            }
        }

        public void ExibirContatos()
        {
            Console.WriteLine("Lista de Contatos:");
            foreach(var contato in contatos)
            {
                Console.WriteLine($@"Nome: {contato.NomeContato}
Número de telefone: {contato.NumeroTelefone}");
            }
        }

        public void EditarContato(string nome)
        {
            for (int i = 0; i < contatos.Count; i++)
            {
                if (contatos[i].NomeContato == nome)
                {
                    Console.WriteLine(@"1 - Editar nome
2 - Editar número
3 - Editar nome e número");
                    int opcao = int.Parse(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Novo nome:");
                        string novoNome = Console.ReadLine();
                        contatos[i].NomeContato = novoNome; 
                        Console.WriteLine("Contato editado com sucesso!");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Novo número do contato:");
                        int novoNumero = int.Parse(Console.ReadLine());
                        contatos[i].NumeroTelefone = novoNumero;
                        Console.WriteLine("Contato editado com sucesso!");
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Novo nome:");
                        string novoNome = Console.ReadLine();
                        Console.WriteLine("Novo número do contato:");
                        int novoNumero = int.Parse(Console.ReadLine());
                        contatos[i].NomeContato = novoNome;
                        contatos[i].NumeroTelefone = novoNumero; 
                        Console.WriteLine("Contato editado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                    return; 
                }
            }
            Console.WriteLine("Contato não encontrado na agenda.");
        }

    }
}

