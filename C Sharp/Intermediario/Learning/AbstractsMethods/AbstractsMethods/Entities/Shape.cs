using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractsMethods.Entities.Enums;

namespace AbstractsMethods.Entities
{
    abstract internal class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
