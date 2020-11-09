using PrjFinal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrjFinal.Contracts
{
    interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        void ListEmail(double value);
        void SalarySum();
    }
}
