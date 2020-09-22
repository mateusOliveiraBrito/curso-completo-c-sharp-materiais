using System;

namespace CadastroProdutos {
    class Program {
        static void Main(string[] args) {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco}, {produto.Quantidade} unidades, Total: $ {produto.ValorTotalEmEstoque()}");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {produto.Nome}, 4 {produto.Preco}, {produto.Quantidade} unidades, Total: $ {produto.ValorTotalEmEstoque()}");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados atualizados: {produto.Nome}, 4 {produto.Preco}, {produto.Quantidade} unidades, Total: $ {produto.ValorTotalEmEstoque()}");
        }
    }
}
