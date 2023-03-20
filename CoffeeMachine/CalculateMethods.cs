using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CalculateMethods
    {
        public static string CalculateTaste(double coffeeTaste, double coef)
        {
            double resultTaste = coffeeTaste * coef;

            switch (resultTaste)
            {
                case < 3:
                    return "Такой себе вкус";

                case >= 3 and < 5:
                    return "Нормальный вкус";

                case >= 5 and < 7:
                    return "Вкусный вкус";

                case >= 7:
                    return "Охиеренный вкусновкус";

                default:
                    return "Неизведанный вкус";
            }
        }

        public static double CalculateCookingSpeed(double cookingSpeed, double coef) 
        {
            return cookingSpeed * coef;
        }
    }
}
