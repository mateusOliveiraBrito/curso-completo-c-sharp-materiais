using System;
using System.Collections.Generic;
using System.Text;

namespace HashCodeEqualsPersonalizado.Entidades
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Cliente))
                return false;

            Cliente newCliente = obj as Cliente;
            return Email.Equals(newCliente.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
