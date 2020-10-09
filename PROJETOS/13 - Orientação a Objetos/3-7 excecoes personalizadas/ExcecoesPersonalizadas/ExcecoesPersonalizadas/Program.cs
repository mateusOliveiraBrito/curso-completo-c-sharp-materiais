using ExcecoesPersonalizadas.Entidades;
using ExcecoesPersonalizadas.Entidades.Exceptions;
using System;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Check-in (DD/MM/AAAA): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out (DD/MM/AAAA): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(numero, checkin, checkout);
                Console.WriteLine($"Reserva: {reserva}");

                Console.WriteLine();

                Console.WriteLine("Entre com os dados para atualizar a reserva:");
                Console.Write("Check-in (DD/MM/AAAA): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out (DD/MM/AAAA): ");
                checkout = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Reserva: {reserva}");
            }
            catch (DominioException ex)
            {
                Console.WriteLine("Erro na reserva: " + ex.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Erro na inserção de dados: " + e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }
        }
    }
}
