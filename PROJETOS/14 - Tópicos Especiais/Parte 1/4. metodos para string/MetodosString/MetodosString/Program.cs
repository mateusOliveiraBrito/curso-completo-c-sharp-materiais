using System;

namespace MetodosString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG";
            Console.WriteLine("Original " + original);
            Console.WriteLine();

            string maiuscula = original.ToUpper();
            Console.WriteLine("maíuscula: " + maiuscula);
            Console.WriteLine();

            string minuscula = original.ToLower();
            Console.WriteLine("minuscula: " + minuscula);
            Console.WriteLine();

            string semBranco = original.Trim();
            Console.WriteLine("sem espaço em branco: " + semBranco);
            Console.WriteLine();

            int primeiroIndice = original.IndexOf("bc"); //valor pra procurar ou uma string
            Console.WriteLine("primeiro índice:" + primeiroIndice);
            Console.WriteLine();

            int ultimoIndex = original.LastIndexOf("bc"); //valor pra procurar ou uma string
            Console.WriteLine("último índice:" + ultimoIndex);
            Console.WriteLine();

            string recorteSimples = original.Substring(3);
            Console.WriteLine("recorte simples: " + recorteSimples);
            Console.WriteLine();

            string recorteComTamanho = original.Substring(3, 6);
            Console.WriteLine("recorte com tamanho: " + recorteComTamanho);
            Console.WriteLine();

            string substituicao = original.Replace('a', '@');
            Console.WriteLine("substituicao: " + substituicao);
            Console.WriteLine();

            string substituicao2 = original.Replace("abc", "888");
            Console.WriteLine("substituicao: " + substituicao2);
            Console.WriteLine();

            bool empty = String.IsNullOrEmpty(original);
            Console.WriteLine("vazia? " + empty);

            bool white = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("é espaço em branco? " + white);
        }
    }
}
