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
            double resultTaste = coffee.Taste * CoefTaste;
            string taste;

            switch (resultTaste)
            {
                case < 3:
                    taste = "Такой себе вкус";
                    break;

                case >= 3 and < 5:
                    taste = "Нормальный вкус";
                    break;

                case >= 5 and < 7:
                    taste = "Вкусный вкус";
                    break;

                case >= 7:
                    taste = "Охиеренный вкусновкус";
                    break;

                default:
                    taste = "Неизведанный вкус";
                    break;
            }

            return $"Ваш {coffee.Name} для Вас готовит {Name}\n" +
                $"Он будет готов через {coffee.CookingSpeed * CoefCookingSpeed} минут\n" +
                $"И у него будет {taste}";

        }
    }
}
