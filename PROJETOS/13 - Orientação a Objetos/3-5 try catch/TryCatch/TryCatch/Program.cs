using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            //stacktrace (rastreamento das chamadas das exceções) = mensagem que descreve o tipo da exceção, 
            //mensagem padrao da exceção e onde ocorreu a exceção

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int resultado = n1 / n2;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido divisão por zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Não é permitido inserir valores não numéricos!");
            }
        }
    }
}
