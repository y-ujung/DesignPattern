using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : Condiment
    {
        Beverage b;

        public Mocha(Beverage b)
        {
            this.b = b;
        }
        public override int cost()
        {
            return 500+b.cost();
        }

        public override string getDescription()
        {
            return b.getDescription() + ", Mocha";
        }
    }
}
