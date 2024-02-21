namespace Exercicio12
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<LojaVirtual> carrinho = new List<LojaVirtual>();
            LojaVirtual loja = new LojaVirtual();
            LojaVirtual produtoUm = new LojaVirtual(1, "Air Force", "Tênis Nike da linha Air Force", "Nike", "Preto", 36, 470.00m, 7);
            LojaVirtual produtoDois = new LojaVirtual(2, "Dunk Low", "Tênis Nike da Sb Dunk", "Nike", "Branco e Cinza", 38, 320.00m, 2);
            LojaVirtual produtoTres = new LojaVirtual(3, "Street Fit", "Tênis Fila da linha Street", "Fila", "Preto", 34, 204.00m, 5);

            while (true)
            {
                Console.WriteLine(@"MENU
1 - CADASTRAR PRODUTO
2 - VITRINE
3 - GERAR CARRINHO
4 - APLICAR DESCONTO
5 - FINALIZAR COMPRA

0 - SAIR");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        return;
                    case 1:
                        LojaVirtual novoProduto = loja.CadastrarProduto();
                        carrinho.Add(novoProduto);
                        break;
                    case 2:
                        produtoUm.InformacoesVitrine();
                        produtoDois.InformacoesVitrine();
                        produtoTres.InformacoesVitrine();
                        break;
                    case 3:
                        Console.WriteLine("Carrinho de Compras:");
                        foreach (var item in carrinho)
                        {
                            Console.WriteLine($"Produto: {item.Nome}, Preço: {item.Preco}, Quantidade: {item.Quantidade}");
                        }
                        break;
                    case 4:
                        decimal total = loja.TotalComprado(carrinho);
                        decimal totalComDesconto = loja.AplicarDesconto(total);
                        Console.WriteLine($"Total da compra com desconto: {totalComDesconto}");
                        break;
                    case 5:
                        Console.WriteLine("Confirma a compra? (S/N)");
                        string confirmacao = Console.ReadLine().ToUpper();
                        if (confirmacao == "S")
                        {
                            Console.WriteLine("Compra finalizada com sucesso!");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }

        }
    }
}
