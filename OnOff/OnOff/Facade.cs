using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Facade
    {
        Light l;
        TV t;

        public Facade(Light l, TV t)
        {
            this.l = l;
            this.t = t;
        }

        public void watchMovie()
        {
            l.on();
            t.on();
        }

        public void endMovie()
        {
            l.off();
            t.off();
        }
    }
}
