using Ex_1_heranca.Entities;
using System;

namespace Ex_1_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Account acc = new Account(101, "Erico", 0.0);
            BusinessAccount bacc = new BusinessAccount(102, "Augusto", 0.0, 500.0);

            // UPCASTING 

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(103, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(104, "Anna", 0.0, 0.01);

            // DOWCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(1000.0);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; // || BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3; // ||  SavingsAccount acc5 = acc3 as SavingsAccount;

                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
            //-------------------------------------------------------------------------------------------------------------------------------

            // *****************SOBREPOSIÇÃO, PALAVRAS VIRTUAIS, OVERRIDE E BASE  - LIÇÃO 127
            Console.WriteLine("SOBREPOSIÇÃO, PALAVRAS VIRTUAIS, OVERRIDE E BASE  - LIÇÃO 127");
            Console.WriteLine();
            Account ac1 = new Account(101, "Erico", 500.0);
            Account ac2 = new SavingsAccount(102, "Augusto", 500.0, 0.01);

            ac1.Withdraw(10.0); // Utilizou o métodp de saque da classe Account -- com taxa de 5.0
            ac2.Withdraw(10.0); // utilizou o método de saque da classe SavingAccount

            Console.WriteLine(ac1.Balance);
            Console.WriteLine(ac2.Balance);

            //





        }
    }
}
