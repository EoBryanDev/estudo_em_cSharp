using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheridanceEmployees.Entities
{
    internal class OutSourcingEmployee : Employee
    {
        public double AddicionalCharge { get; set; }

        public OutSourcingEmployee() { }

        public OutSourcingEmployee(string name, int hours, double valuePerHour, double addicionalCharge) 
            :base(name,hours,valuePerHour)
        {
            AddicionalCharge = addicionalCharge;
        }

        public override double Payment()
        {

            
            double amount = base.Payment() + (1.1 * AddicionalCharge);
            return amount;
        }
    }
}
