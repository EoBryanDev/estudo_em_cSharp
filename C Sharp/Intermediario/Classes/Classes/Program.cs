using Classes.Entities;
using Classes.Entities.Enums;
using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order { 
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus),"Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(status);
           



            Console.ReadLine();

        }
    }
}
