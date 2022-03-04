using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_1.Entities.Enums;
using Exercise_1.Entities;
using System.Globalization

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior): ");

            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract date: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours)");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

                Console.WriteLine();
                Console.Write("Enter month and year to calculate income (MM/YYYY): ");
                string monthAndYear = Console.ReadLine();
                int month = int.Parse(monthAndYear.Substring(0, 2));
                int year = int.Parse(monthAndYear.Substring(3));

                Console.WriteLine($"Name: {worker.Name}");
                Console.WriteLine($"Department: {worker.Department.Name}");
                Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture)}");


            }

        }
    }
}
