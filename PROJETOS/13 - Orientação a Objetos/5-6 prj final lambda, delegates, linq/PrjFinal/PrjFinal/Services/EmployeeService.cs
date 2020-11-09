using PrjFinal.Contracts;
using PrjFinal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrjFinal.Services
{
    class EmployeeService : IEmployeeService
    {
        List<Employee> list = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            list.Add(employee);
        }

        public void ListEmail(double value)
        {
            var result = list.Where(x => x.Salary > value).OrderBy(y => y.Email).Select(z => z.Email).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void SalarySum()
        {
            var result = (from e in list
                          where e.Name[0] == 'M'
                          select e).Select(x => x.Salary).Sum();
            Console.WriteLine(result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
