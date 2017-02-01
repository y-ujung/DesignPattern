using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ComputerAdapter : IProducts
    {
        Computer com;

        public ComputerAdapter(Computer com)
        {
            this.com = com;
        }
        public void off()
        {
            for(int i=0; i<2; i++)
                com.off();
        }

        public void on()
        {
            com.fix();
        }
    }
}
