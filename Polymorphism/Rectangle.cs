using System;
using System.Collections.Generic;


namespace Polymorphism
{
    public class Rectangle : Square
    {
        private readonly double _sideB;

        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            _sideB = sideB;
        }

        protected override double AreaOfShape()
        {
            return SideA * _sideB;
        }

        public override void ShowAreaOfShape()
        {
            Console.WriteLine($"\nПлощадь прямоугольника со сторонами {SideA} и " +
                $"{_sideB} = {AreaOfShape()}");
        }
    }
}
