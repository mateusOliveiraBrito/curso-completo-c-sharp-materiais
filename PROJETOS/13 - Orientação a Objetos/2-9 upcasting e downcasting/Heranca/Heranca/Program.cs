using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account conta = new Account(1001, "Alex", 0.0);
            BusinessAccount contaNegocio = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING : conversão de subclasse para super classe
            Account acc = contaNegocio;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            /*
             * é possível realizar esse tipo de conversão, por que, SavingsAccount e BusinessAccount fazem relação
             * "é um" com a classe Account, logo essas subclasses são do tipo da super classe, logo, o compilador
             * permite fazer essa conversão (casting) de forma harmônica
             */

            //DOWNCASTING : conversão da super classe para a subclasse
            BusinessAccount bac = (BusinessAccount)acc2;
            bac.Loan(100.0);

            //BusinessAccount bacc3 = (BusinessAccount)acc3; -> dispara exceção

            //para testar se acc3 é do tipo BusinessAccount:
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount bacc = (BusinessAccount)acc3;
                //ou
                BusinessAccount bacc = acc3 as BusinessAccount;
                bacc.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount sacc = (SavingsAccount)acc3;
                sacc.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
