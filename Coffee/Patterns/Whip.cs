using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Whip : Condiment
    {
        Beverage b;

        public Whip(Beverage b)
        {
            this.b = b;
        }
        public override int cost()
        {
            return 300 + b.cost();
        }
        public override string getDescription()
        {
            return b.getDescription() + ", Whip";
        }
    }
}
