using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CapsuleCoffeeMachine : CoffeeMachine
    {
        public override string Name => "Капсульная кофемашина";

        public CapsuleCoffeeMachine()
        {
            CoefTaste = 0.8;
            CoefCookingSpeed = 0.7;
        }
    }
}
