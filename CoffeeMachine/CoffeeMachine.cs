using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public abstract class CoffeeMachine : IHasName
    {
        protected double CoefTaste;
        protected double CoefCookingSpeed;
        public abstract string Name { get; }

        public string MakeCoffee(Coffee coffee)
        {
            return $"Ваш {coffee.Name} для Вас готовит {Name}\n" +
                $"Он будет готов через {CalculateMethods.CalculateCookingSpeed(CoefCookingSpeed, coffee.CookingSpeed)} минут\n" +
                $"И у него будет {CalculateMethods.CalculateTaste(CoefTaste, coffee.Taste)}";

        }
    }
}
