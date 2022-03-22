using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceHeritage.Entities;
using System.Globalization;

namespace InterfaceHeritage.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Math.Pow(2, Radius);
        }

        public override string ToString()
        {
            return $"Circle color = {Color} and Radius = {Radius.ToString("f2", CultureInfo.InvariantCulture)} " +
                $", Area = {Area().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
