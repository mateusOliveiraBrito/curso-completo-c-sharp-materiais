using LinqLambda.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqLambda
{
    class Program
    {
        public static void Print<T>(string mensagem, IEnumerable<T> colecao)
        {
            Console.WriteLine(mensagem);

            foreach (var item in colecao)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Categoria c1 = new Categoria(1, "Ferramentas", 2);
            Categoria c2 = new Categoria(2, "Computadores", 1);
            Categoria c3 = new Categoria(3, "Eletrônicos", 4);

            List<Produto> produtos = new List<Produto>() {
                new Produto(1, "Computador", 600, c2),
                new Produto(2, "Chave de fenda", 1100, c1),
                new Produto(3, "Parafuso", 1100, c1),
                new Produto(4, "Microondas", 2500, c3)
            };

            // var result1 = produtos.Where(p => p.Categoria.Nota == 1 && p.Preco < 900);
            var result1 = from p in produtos where p.Categoria.Nota == 1 && p.Preco < 900 select p;
            Print("Nota 1 e preco < 900:", result1);

            // var result2 = produtos.Where(p => p.Categoria.Nome == "Ferramentas").Select(x => x.Nome);
            var result2 = from p in produtos where p.Categoria.Nome == "Ferramentas" select p.Nome;
            Print("Nomes dos produtos da categoria ferramentas", result2);

            // var result3 = produtos.Where(p => p.Nome[0] == 'C').Select(x => new { x.Nome, x.Preco, NomeCategoria = x.Categoria.Nome }); //criação de objeto anonimo
            var result3 = from p in produtos where p.Nome[0] == 'C' select new { p.Nome, p.Preco, CategoriaNome = p.Categoria.Nome };
            Print("Nomes dos produtos iniciados com C e objeto anonimo", result3);

            // var result4 = produtos.Where(p => p.Categoria.Nota == 1).OrderBy(x => x.Preco).ThenBy(p => p.Nome); // ordenando por preco e desempatando por nome; ordem decresente OrderByDescending
            var result4 = from p in produtos where p.Categoria.Nota == 1 orderby p.Nome, p.Preco select p; //os itens de ordenação devem estar na ordem inversa da consulta anterior 
            Print("Nota 1 ordenado por preco e nome", result4);

            //NO CASO DOS TERMINADORES, DEVE-SE COLOCAR AS CONSULTAS ENTRE PARENTÊSES E DEPOIS ADICIONAR O TERMINADOR EMBAIXO, EXEMPLO:
            //var result5 = produtos.Skip(1).Take(3);
            var result5 = (from p in produtos select p).Skip(1).Take(3);
            Print("Lista todos, pula 1 e pega o 3 (o ´3 é o 4° objeto)", result5);

            /*var result6 = produtos.First();
            Console.WriteLine("Firt teste 1: " + result6);

            var result7 = produtos.Where(p => p.Preco > 3000).FirstOrDefault(); //se nao encontrar nenhum, retornará nulo
            Console.WriteLine("Firt teste 2: " + result7);

            var result8 = produtos.Where(p => p.Id == 3).SingleOrDefault(); //retorna um ou nulo se nao existir
            Console.WriteLine("Single or default: " + result8);

            var result9 = produtos.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default 2: " + result9);

            var result10 = produtos.Max(p => p.Preco); //sem parametros (deve implementar o IComparable) ou com funcao lambda
            Console.WriteLine("Preco Maximo: " + result10);

            var result11 = produtos.Min(p => p.Preco); //sem parametros (deve implementar o IComparable) ou com funcao lambda
            Console.WriteLine("Preco Minimo: " + result11);

            var result12 = produtos.Where(p => p.Categoria.Id == 1).Sum(x => x.Preco); //soma dos precos
            Console.WriteLine("Categoria 1, soma dos preços: " + result12);

            var result13 = produtos.Where(p => p.Categoria.Id == 1).Average(x => x.Preco); //media dos precos
            Console.WriteLine("Categoria 1, media dos preços: " + result13);

            var result14 = produtos.Where(p => p.Categoria.Id == 30).Select(p => p.Preco).DefaultIfEmpty(0.0).Average(); //media: se o resultado da consulta for vazio, atribui o valor zero
            Console.WriteLine("Categoria inexistente, validando possivel erro: " + result14);

            var result15 = produtos.Where(p => p.Categoria.Id == 1).Select(x => x.Preco).Aggregate(0.0, (x, y) => x + y); //a sobrecarga recebe o 0.0 antes dos atributos pois ele será o valor default caso o resultado seja vazio
            Console.WriteLine("Categoria 1, aggregate sum, validando retorno vazio: " + result15);

            Console.WriteLine();*/

            //var result16 = produtos.GroupBy(x => x.Categoria);
            var result16 = from p in produtos group p by p.Categoria;

            foreach (IGrouping<Categoria, Produto> grupo in result16)
            {
                Console.WriteLine("Categoria: " + grupo.Key.Nome + ":");

                foreach (var item in grupo)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

        }
    }
}
