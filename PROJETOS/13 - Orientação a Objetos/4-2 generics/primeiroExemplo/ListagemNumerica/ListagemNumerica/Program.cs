using ListagemNumerica.Contratos;
using ListagemNumerica.Servicos;
using System;

namespace ListagemNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            IImpressaoServico _impressaoServico = new ImpressaoServico();

            Console.Write("Informe quantos números serão lidos: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    _impressaoServico.AddObjeto(Console.ReadLine());
                }

                _impressaoServico.Imprime();
                Console.WriteLine($"Primeiro: {_impressaoServico.Primeiro()}");
            }
            else
            {
                Console.WriteLine("O valor informado está fora do intervalo permitido!");
            }
        }
    }
}
