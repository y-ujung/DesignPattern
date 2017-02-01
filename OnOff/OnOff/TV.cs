using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommandPattern
{
    public class TV : IProducts
    {
        public void on()
        {
            MessageBox.Show("TV On");
        }

        public void off()
        {
            MessageBox.Show("TV Off");
        }
    }
}
