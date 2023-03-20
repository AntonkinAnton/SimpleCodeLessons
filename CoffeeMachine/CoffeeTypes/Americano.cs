using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Americano : Coffee
    {
        public override double Taste => 3;
        public override double CookingSpeed => 5;
        public override string Name => "Американо";

    }
}
