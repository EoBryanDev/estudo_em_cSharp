using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Entities
{
    internal class Emplyoee
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public double Salary { get; set; }

        public Emplyoee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
