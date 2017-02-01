using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {

        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override int cost()
        {
                return 5000;
        }
    }
}
