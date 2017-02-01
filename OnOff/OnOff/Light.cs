using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandPattern
{
    public class Light : IProducts
    {
        public void on()
        {
            MessageBox.Show("Ligth On");
        }

        public void off()
        {
            MessageBox.Show("Ligth Off");
        }
    }
}
