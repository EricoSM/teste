using Ex2_Poli.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex2_Poli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de fixação");
            Console.WriteLine();

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");                
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Cuntoms fee: ");
                    double custonFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, custonFee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
