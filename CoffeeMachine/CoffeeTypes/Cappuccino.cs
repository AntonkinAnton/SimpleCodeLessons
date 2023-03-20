using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Cappuccino : Coffee
    {
        public override double Taste => 5;
        public override double CookingSpeed => 7;
        public override string Name => "Капучино";

    }
}
