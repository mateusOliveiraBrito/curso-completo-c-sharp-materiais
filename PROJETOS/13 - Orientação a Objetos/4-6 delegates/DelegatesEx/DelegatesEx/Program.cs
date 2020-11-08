using DelegatesEx.Services;
using System;

namespace DelegatesEx
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10, b = 12;

            BinaryNumericOperation op = CalculationService.Max;
            //double result = op(a, b);
            double result = op.Invoke(a, b);

            Console.WriteLine(result);
        }
    }
}
