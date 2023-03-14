using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Square : Shape
    {
        public double SideA { get; private set; }

        public Square(double side)
        {
            SideA = side;
        }

        public override double AreaOfShape()
        {
            return SideA * SideA;
        }

    }
}
