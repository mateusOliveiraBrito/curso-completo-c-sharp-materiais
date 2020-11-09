using PrjFinal.Contracts;
using PrjFinal.Entities;
using PrjFinal.Services;
using System;
using System.Globalization;
using System.IO;

namespace PrjFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IEmployeeService _employeeService = new EmployeeService();
                string path = @"c:\temp\users.csv";

                using (StreamReader str = File.OpenText(path))
                {
                    while (!str.EndOfStream)
                    {
                        var line = str.ReadLine().Split(',');
                        Employee e = new Employee(line[0], line[1], double.Parse(line[2], CultureInfo.InvariantCulture));
                        _employeeService.AddEmployee(e);
                    }
                }

                Console.Write("Enter salary: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.WriteLine($"Email of people whose salary is more than {value}");
                _employeeService.ListEmail(value);

                Console.Write("Sum of salary of people whose name starts with 'M': ");
                _employeeService.SalarySum();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
        }
    }
}
