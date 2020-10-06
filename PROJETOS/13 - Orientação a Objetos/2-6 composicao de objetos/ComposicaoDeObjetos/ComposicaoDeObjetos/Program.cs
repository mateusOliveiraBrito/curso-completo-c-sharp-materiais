using ComposicaoDeObjetos.Entities;
using ComposicaoDeObjetos.Entities.Enums;
using System;
using System.Globalization;

namespace ComposicaoDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("-Name: ");
            string name = Console.ReadLine();
            Console.Write("-Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("-Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");

            int nContracts = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= nContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("-Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("-Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("-Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine();

                HourContract contract = new HourContract(contractDate, valueHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for ({monthAndYear}): {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
