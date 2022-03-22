using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHeritage.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"Circle color = {Color} and Width = " +
                $"{Width.ToString("f2", CultureInfo.InvariantCulture)} " +
                $", Heigh = {Height.ToString("f2", CultureInfo.InvariantCulture)}" +
                $", Area = {Area().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}

