using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Espresso : Beverage
    {

        public Espresso()
        {
            description = "Espresso";
        }

        public override int cost()
        {
                return 4000;
        }
    }
}
