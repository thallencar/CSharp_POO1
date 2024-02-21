namespace Exercicio14
{
    public class MaquinaDeVendas
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Preco { get; private set; }

        public MaquinaDeVendas(int id, string nome, int quantidade, decimal preco)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public MaquinaDeVendas()
        {

        }

        public MaquinaDeVendas CadastrarProduto()
        {
            Console.WriteLine(@$"CADASTRO DE PRODUTOS");
            Console.WriteLine("IDENTIFICADOR: ");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("NOME: ");
            Nome = Console.ReadLine();

            Console.WriteLine("PREÇO: ");
            Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("QUANTIDADE: ");
            Quantidade = int.Parse(Console.ReadLine());

            return new MaquinaDeVendas(Id, Nome, Quantidade, Preco);
        }


        public void SelecionarProduto(List<MaquinaDeVendas> produtos)
        {
            InserirDinheiro();


            Console.WriteLine("Selecione um produto (código de identificação): ");
            int idSelecionado = int.Parse(Console.ReadLine());

            bool produtoEncontrado = false;
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Id == idSelecionado)
                {
                    Console.WriteLine($"Produto selecionado: {produtos[i].Nome}");
                    produtos.RemoveAt(i);
                    produtoEncontrado = true;
                    break;
                }
            }

            if (!produtoEncontrado)
            {
                Console.WriteLine("Produto não encontrado na lista");
            }
        }


        public decimal InserirDinheiro()
        {
            Console.WriteLine("Insira o dinheiro: ");
            decimal dinheiroInserido = decimal.Parse(Console.ReadLine());
            

            if (dinheiroInserido == Preco)
            {
                return dinheiroInserido;
            }
            else if (dinheiroInserido > Preco)
            {
                decimal troco = dinheiroInserido - Preco;
                Console.WriteLine($"Troco: R${troco}");
                return Preco;
            }
            else
            {
                Console.WriteLine("Insira a quantia correta de dinheiro.");
                return 0;
            }
        }

        public void ExibirEstoque()
        {
            Console.WriteLine($"Estoque disponível: {Nome}: {Quantidade}");
        }
    }
}