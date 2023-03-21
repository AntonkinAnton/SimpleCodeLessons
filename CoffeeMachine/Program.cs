using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user = new Human();
            var capsule = new CapsuleCoffeeMachine();
            var carob = new CarobCoffeeMachine();

            user.CookCoffee(capsule, new Cappuccino());
            user.CookCoffee(capsule, new Americano());
            user.CookCoffee(capsule, new Latte());
            user.CookCoffee(carob, new Cappuccino());
            user.CookCoffee(carob, new Americano());
            user.CookCoffee(carob, new Latte());
            Console.ReadKey();

        }
    }
}
