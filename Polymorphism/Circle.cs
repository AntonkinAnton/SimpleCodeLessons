using System;


namespace Polymorphism
{
    public class Circle : Shape
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            _radius = radius;
        }

        protected override double AreaOfShape()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }

        public override void ShowAreaOfShape()
        {
            Console.WriteLine($"\nПлощадь круга с радиусом {_radius} = {AreaOfShape()}");
        }
    }
}
