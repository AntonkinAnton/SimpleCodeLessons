using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(GetDouble("Введите радиус круга:"));
            ShowAreaOfShape(circle);
            Console.ReadKey(); 
            Console.Clear();

            Square square = new Square(GetDouble("Введите сторону квадрата:"));
            ShowAreaOfShape(square);
            Console.ReadKey();
            Console.Clear();

            Rectangle rectangle = new Rectangle(GetDouble("Введите первую сторону квадрата:"),
                GetDouble("Введите вторую сторону квадрата:"));
            ShowAreaOfShape(rectangle);
            Console.ReadKey();
        }


            public static void ShowAreaOfShape(Shape shape)
            {
                switch (shape)
                {
                    case Circle circle:
                        Console.WriteLine($"\nПлощадь круга с радиусом {circle.Radius} = {circle.AreaOfShape()}");
                        break;

                    case Rectangle rectangle:
                    Console.WriteLine($"\nПлощадь прямоугольника со сторонами {rectangle.SideA} и {rectangle.SideB}" +
                        $"= {rectangle.AreaOfShape()}");
                    break;

                    case Square square:
                        Console.WriteLine($"\nПлощадь квадрата со стороной {square.SideA} = {square.AreaOfShape()}");
                        break;

                }

            }

        public static double GetDouble (string message)
        {
            int yCursorPos = Console.CursorTop;
            double input;

            do
            {
                Console.SetCursorPosition(0, yCursorPos);
                Console.WriteLine(message);
                Console.Write(new string(' ', Console.LargestWindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop-1);

            } while (!double.TryParse(Console.ReadLine(), out input));

            return input;
        }
    }
}
