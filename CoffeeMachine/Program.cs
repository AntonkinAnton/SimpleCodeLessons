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
            user.CookCoffee(new CapsuleCoffeeMachine(), new Cappuccino());
            user.CookCoffee(new CapsuleCoffeeMachine(), new Americano());
            user.CookCoffee(new CapsuleCoffeeMachine(), new Latte());
            user.CookCoffee(new CarobCoffeeMachine(), new Cappuccino());
            user.CookCoffee(new CarobCoffeeMachine(), new Americano());
            user.CookCoffee(new CarobCoffeeMachine(), new Latte());
            Console.ReadKey();

        }
    }
}
