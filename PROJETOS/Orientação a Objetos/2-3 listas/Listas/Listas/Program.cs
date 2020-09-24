using System;
using System.Collections.Generic;

namespace Listas {
    class Program {
        static void Main(string[] args) {

            //declara e instancia a lista
            List<string> list = new List<string>();

            //método que adiciona itens ao final da lista
            list.Add("Mateus");
            list.Add("Jake");
            list.Add("Altair");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            //método que adiciona itens à lista com base em uma posição informada, sem remover o valor já existente na posição
            list.Insert(0, "Teste");

            foreach(var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //método que retorna o tamanho da lista
            Console.WriteLine($"Tamanho da lista: {list.Count}");
            Console.WriteLine();

            //método que encontra o primeiro item da lista com base (corresponde) em um predicado
            string s1 = list.Find(Teste); //ou s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"Primeira ocorrência que inicia com a letra A: {s1}");

            //método que encontra o último item da lista com base (corresponde) em um predicado
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Última ocorrência que inicia com A: {s2}");
            Console.WriteLine();

            //método que retorna o índice da primeiro item da lista com base (corresponde) em um predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"Primeiro índice: {pos1}");

            //método que retorna o índice do último item da lista com base (corresponde) em um predicado
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Segundo índice: {pos2}");
            Console.WriteLine();

            //realizando filtro na lista
            List<string> filtro = list.FindAll(x => x[0] == 'A');
            Console.WriteLine("Lista filtrada: ");
            foreach(var item in filtro) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //remove um item informado
            list.Remove("Jake");
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //remove todos os itens que corresponde à um predicado
            list.RemoveAll(x => x[0] == 'M');
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //remove o item em uma posição informada
            list.RemoveAt(2);
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //remove os elementos de uma faixa (um intervalo)
            //primeiro parametro = posição & segundo parâmetro = contagem
            list.RemoveRange(0, 2); //"a partir da posição zero, remove dois itens"
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }

        static bool Teste(string s) {
            return s[0] == 'A';
        }
    }
}
