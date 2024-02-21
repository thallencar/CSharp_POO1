using Exercicio14;

class Program
{
    static void Main(string[] args)
    {
        List<MaquinaDeVendas> produtos = new List<MaquinaDeVendas>();
        MaquinaDeVendas foneDeOuvido = new MaquinaDeVendas(1, "Fone de ouvido", 10, 30.00m);
        MaquinaDeVendas carregadorPortatil = new MaquinaDeVendas(2, "Carregador portátil", 15, 50.00m);
        MaquinaDeVendas caixaDeSom = new MaquinaDeVendas(3, "Caixa de som", 6, 40.00m);
        MaquinaDeVendas caixaSurpresa = new MaquinaDeVendas(4, "Caixa surpresa", 8, 70.00m);

        while (true)
        {
            Console.WriteLine(@"MAQUINA DE VENDAS
1 - PRODUTOS DISPONÍVEIS
2 - ESTOQUE
3 - CADASTRAR PRODUTO
4 - SELECIONAR PRODUTO

0 - SAIR");

            int option;

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine(@$"PRODUTOS DISPONÍVEIS
{foneDeOuvido.Nome}
{carregadorPortatil.Nome}
{caixaDeSom.Nome}
{caixaSurpresa.Nome}");
                    
                    foreach (var produto in produtos)
                    {
                        Console.WriteLine($"{produto.Nome}");
                    }
                    break;
                case 2:
                    foneDeOuvido.ExibirEstoque();
                    carregadorPortatil.ExibirEstoque();
                    caixaDeSom.ExibirEstoque();
                    caixaSurpresa.ExibirEstoque();
                    foreach (var produto in produtos)
                    {
                        produto.ExibirEstoque();
                    }
                    break;
                case 3:
                    MaquinaDeVendas novoProduto = new MaquinaDeVendas();
                    novoProduto.CadastrarProduto();
                    produtos.Add(novoProduto);
                    break;
                case 4:
                    produtos.Add(foneDeOuvido);
                    produtos.Add(carregadorPortatil);
                    produtos.Add(caixaDeSom);
                    produtos.Add(caixaSurpresa);
                    foreach (var produto in produtos)
                    {
                        produto.SelecionarProduto(produtos);
                    }

                    break;
                default:
                    Console.WriteLine("Erro! Digite um valor válido.");
                    break;
            }
        }
    }
}
