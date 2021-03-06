using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheridanceEmployees.Entities;
using System.Globalization;

namespace InheridanceEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter the number of employees: ");
            int n  = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 'y')
                {
                    Console.Write("Addicional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcingEmployee(name, hours, valuePerHour, addicionalCharge));

                } else
                {
                    list.Add(new Employee(name,hours,valuePerHour));
                }
            }
            Console.WriteLine();

            foreach(Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2",CultureInfo.InvariantCulture)}");
                
            }
            Console.ReadKey();
        }
    }
}
