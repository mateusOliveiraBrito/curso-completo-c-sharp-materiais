using ExcecoesPersonalizadas.Entidades.Exceptions;
using System;

namespace ExcecoesPersonalizadas.Entidades
{
    class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime checkin, DateTime checkout)
        {

            if (checkout <= checkin)
            {
                throw new Exception("Erro na reserva: Datas cronológicamente incompatíveis!");
            }

            NumeroQuarto = numeroQuarto;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duracao()
        {
            TimeSpan duracao = Checkout.Subtract(Checkin);
            return (int)duracao.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {

            DateTime agora = DateTime.Now;

            if (checkin < agora || checkout < agora)
            {
                throw new DominioException("Erro na reserva: data para atualização de reserva, devem ser datas futuras!");
            }
            if (checkout <= checkin)
            {
                throw new Exception("Erro na reserva: Datas cronológicamente incompatíveis!");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return $"Quarto {NumeroQuarto}, check-in: {Checkin.ToString("dd/MM/yyyy")}, check-out: {Checkout.ToString("dd/MM/yyyy")}, {Duracao()} noites";
        }
    }
}
