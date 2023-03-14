using System;


namespace Polymorphism
{
    public class Program
    {
        static void Main()
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
            shape.ShowAreaOfShape();
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
