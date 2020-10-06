using ComposicaoDeObjetos.Entities.Enums;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace ComposicaoDeObjetos.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //faz relação entre duas classes diferentes (composição de objetos)
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker()
        {
            Contracts = new List<HourContract>();
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) : this()
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double salary = 0d;

            foreach (var item in Contracts)
            {
                if (item.Date.Year == year && item.Date.Month == month)
                    salary += item.TotalValue();
            }

            return salary + BaseSalary;
        }
    }
}
