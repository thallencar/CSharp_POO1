using System.Numerics;

namespace Exercicio12
{
    public class LojaVirtual
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Tamanho { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public LojaVirtual(int id, string nome, string descricao, string marca, string cor, int tamanho, decimal preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Marca = marca;
            Cor = cor;
            Tamanho = tamanho;
            Preco = preco;
            Quantidade = quantidade;
        }

        public LojaVirtual()
        {
            
        }

        public LojaVirtual CadastrarProduto()
        {
            Console.WriteLine(@$"CADASTRO DE PRODUTOS");
            Console.WriteLine("IDENTIFICADOR: ");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("NOME: ");
            Nome = Console.ReadLine();

            Console.WriteLine("MARCA: ");
            Marca = Console.ReadLine();

            Console.WriteLine("DESCRIÇÃO: ");
            Descricao = Console.ReadLine();

            Console.WriteLine("COR: ");
            Cor = Console.ReadLine();

            Console.WriteLine("TAMANHO: ");
            Tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("PREÇO: ");
            Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("QUANTIDADE: ");
            Quantidade = int.Parse(Console.ReadLine());

            return new LojaVirtual(Id, Nome, Marca, Descricao, Cor, Tamanho, Preco, Quantidade);
        }

        public List<LojaVirtual> GerarCarrinho() {
            List<LojaVirtual> carrinho = new List<LojaVirtual>();
            while (true)
            {
                LojaVirtual produto = CadastrarProduto();
                carrinho.Add(produto);

                Console.WriteLine("Deseja adicionar mais algum produto ao carrinho?");
                char resposta = char.Parse(Console.ReadLine().ToUpper());
                if (resposta == 'S')
                {
                    continue;
                } else
                {
                    break;
                }
            }

            return carrinho;

        }

        public decimal TotalComprado(List<LojaVirtual> carrinho)
        {
            decimal totalCompras = 0;
            foreach (var produto in carrinho)
            {
                totalCompras += produto.Preco * produto.Quantidade;
            }
            return totalCompras;
        }

        public void InformacoesVitrine()
        {
            Console.WriteLine(@$"VITRINE: 
{Id}, {Nome}, {Marca}, {Descricao}, {Cor}, {Tamanho}, {Preco}, {Quantidade}");
        }

        public decimal AplicarDesconto(decimal totalCompras)
        {
            decimal desconto = 0;

            if (totalCompras >= 250.00m)
            {
                desconto = totalCompras * 0.05m; 
            }else if (totalCompras >= 500)
            {
                desconto = totalCompras * 0.10m;
            }else if(totalCompras >= 750)
            {
                desconto = totalCompras * 0.20m;
            }else
            {
                desconto = 0;
            }
            return totalCompras - desconto;
        }
    }
}
