using Ex3_Poli.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;

namespace Ex3_Poli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício método Abstrato");
            Console.WriteLine();

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number fo tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name + ": $ " + tax.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();


            Console.Write("TOTAL TAXES: $ ");
            double sum = 0.0;
            foreach (TaxPayer tax1 in list)
            {
                sum += tax1.Tax();
            }
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
