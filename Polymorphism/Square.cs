using System;


namespace Polymorphism
{
    public class Square : Shape
    {
        protected readonly double SideA;

        public Square(double side)
        {
            SideA = side;
        }

        protected override double AreaOfShape()
        {
            return Math.Pow(SideA,2);
        }

        public override void ShowAreaOfShape()
        {
            Console.WriteLine($"\nПлощадь квадрата со стороной {SideA} = {AreaOfShape()}");
        }
    }
}
