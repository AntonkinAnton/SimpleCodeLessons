using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle : Square
    {
        public double SideB { get; private set; }

        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            SideB = sideB;
        }

        public override double AreaOfShape()
        {
            return SideA * SideB;
        }
    }
}
