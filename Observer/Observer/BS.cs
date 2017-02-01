using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Observer
{
    public class BS : IObserver
    {
        public BS()
        {
            MessageBox.Show("Add BS");
        }

        public void update(int number)
        {
            MessageBox.Show("BS number : " + number);
        }
    }
}
