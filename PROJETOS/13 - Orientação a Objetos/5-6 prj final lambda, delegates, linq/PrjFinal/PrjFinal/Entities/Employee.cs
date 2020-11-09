using System;
using System.Collections.Generic;
using System.Text;

namespace PrjFinal.Entities
{
    class Employee
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
