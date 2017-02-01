using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandPattern
{
    public class Computer : IComputer
    {
        public void fix()
        {
            MessageBox.Show("Computer Fix");
        }

        public void off()
        {
            MessageBox.Show("Computer Off");
        }
    }
}
