using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Observer
{
    public class LAB : IObserver
    {
        public LAB()
        {
            MessageBox.Show("Add LAB");
        }

        public void update(int number)
        {
            MessageBox.Show("LAB number : " + number);
        }
    }
}
