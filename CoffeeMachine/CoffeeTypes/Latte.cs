using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Latte : Coffee
    {
        public override double Taste => 7;
        public override double CookingSpeed => 10;
        public override string Name => "Латте";
    }
}
