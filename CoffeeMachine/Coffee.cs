using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public abstract class Coffee : IHasName
    {
        public abstract double Taste { get;  }
        public abstract double CookingSpeed { get; }
        public abstract string Name { get; }
    }
}
