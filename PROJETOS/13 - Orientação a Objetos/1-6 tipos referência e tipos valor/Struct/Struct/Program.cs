using System;

namespace Struct {
    class Program {
        static void Main(string[] args) {
            //foram atribuídos os valores para X e Y para que o compilador entenda que o struct (variável) foi inicializado
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            /*
             Se depois de definir valores para X e Y fazer uma instância do objeto, os valores serão recriados 
             e irão assumir o valor zero
             Exemplo: p = new Point();
             */

            /*
             * CONCLUSÃO: mesmo sendo struct, deve-se inicializar, seja definindo valores ou instanciando o objeto
             */
        }
    }
}
