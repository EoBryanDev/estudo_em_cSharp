using Exercise_3.Entities;
using Exercise_3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client datas: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bday = DateTime.Parse(Console.ReadLine());

            //Client build
            Client client = new Client(name,email,bday);

            DateTime registerMoment = DateTime.Now;

            Console.WriteLine("Enter Order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(registerMoment, status, client);

   

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string namep = Console.ReadLine();

                Console.Write("Product price: ");
                double pricep = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                                
                Product p1 = new Product(namep, pricep);

                Console.Write("Quantity: ");
                int qnt = int.Parse(Console.ReadLine());

                OrderItem oi = new OrderItem(qnt, pricep, p1);

                order.addItem(oi);

                
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(order);

            
            

            //OrderItem oi2 = new OrderItem(2,p2.Price);





        }
    }
}
