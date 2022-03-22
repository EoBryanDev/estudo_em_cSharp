﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceHeritage.Entities.Enum;

namespace InterfaceHeritage.Entities
{
    abstract class Shape
    {
     public Color Color { get; set; }

        public abstract double Area();
    }
}

