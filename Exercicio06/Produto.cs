namespace Exercicio06
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public decimal CalcularValorTotal()
        {
            decimal total = Preco * Quantidade;
            Console.WriteLine($"O valor total do produto {Nome} em estoque é de R${total}");
            return total;
        }

        public void VerificaDisponibilidade() {

            if (Quantidade == 0) 
            {
                Console.WriteLine($"{Nome}: O produto se encontra indisponível no momento.");
            }else
            {
                Console.WriteLine($@"Produto: {Nome}
Quantidade: {Quantidade}");
            }
        }
    }

}
