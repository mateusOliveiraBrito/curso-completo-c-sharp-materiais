using PrjEnum.Entidades.Enums;
using System;

namespace PrjEnum.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}