using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Human
    {
        public void CookCoffee(CoffeeMachine coffeeMachine, Coffee coffee)
        {
            Console.WriteLine(coffeeMachine.MakeCoffee(coffee));
            Console.WriteLine();
        }
    }
}
