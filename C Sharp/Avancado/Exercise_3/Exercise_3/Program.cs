using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_3.Entities;
using System.Globalization;
using System.IO;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();

            Console.WriteLine("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
            List<Emplyoee> emplyoees = new List<Emplyoee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] register = sr.ReadLine().Split(',');
                    string name = register[0];
                    string email = register[1];
                    double fullsalary = double.Parse(register[2],CultureInfo.InvariantCulture);

                    emplyoees.Add(new Emplyoee(name, email, fullsalary));
                
                }
            }

            var sal = emplyoees
                .Where(e => e.Salary > salary)
                .OrderBy(e => e.Email)
                .Select(e => e.Email)
                ;
            Console.WriteLine("Email of people whose salary is more than 2000.00: ");

            foreach (string email in sal)
            {
                Console.WriteLine(email);
            }

            var sum = emplyoees
                .Where(e => e.Name[0] == 'M')
                .Sum(e => e.Salary);

            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
