using Enum_e_1.Entities;
using Enum_e_1.Entities.Enums;
using System;

namespace Enum_e_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Order order = new Order
            {
                Id = 1899,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();  //enumeração para string

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //String para enumeração

            Console.WriteLine(os);
        }
    }
}
