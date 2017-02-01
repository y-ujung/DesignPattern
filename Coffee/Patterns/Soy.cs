using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy : Condiment
    {
        Beverage b;

        public Soy(Beverage b)
        {
            this.b = b;
        }
        public override int cost()
        {
            return 700 + b.cost();
        }

        public override string getDescription()
        {
            return b.getDescription() + ", Soy";
        }
    }
}
