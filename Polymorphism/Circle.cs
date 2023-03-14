using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Circle : Shape
    {
        const double PI = 3.14;
        public double Radius { get;private set; }
        
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double AreaOfShape()
        {
            return Radius * Radius * PI;
        }
    }
}
