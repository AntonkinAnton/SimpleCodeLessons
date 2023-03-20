using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CarobCoffeeMachine : CoffeeMachine
    {
        public override string Name => "Рожковая кофемашина";

        public CarobCoffeeMachine() 
        {
            CoefTaste = 1.4;
            CoefCookingSpeed = 1.7;
        }
    }
}
