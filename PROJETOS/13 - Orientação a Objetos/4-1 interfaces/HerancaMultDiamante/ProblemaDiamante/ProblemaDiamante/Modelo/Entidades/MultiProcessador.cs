using ProblemaDiamante.Modelo.Contratos;

namespace ProblemaDiamante.Modelo.Entidades
{
    class MultiProcessador : Dispositivo, IScanner, IImpressora
    {
        public override void ProcessamentoDoc(string documento)
        {
            System.Console.WriteLine($"Multiprocessador processando: {documento}");
        }

        public void Print(string documento)
        {
            System.Console.WriteLine($"Multiprocessador imprimindo: {documento}");
        }

        public string Scan()
        {
            return "Resultado do scaneamento do Scanner";
        }
    }
}
