using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Observer
{
    public class Office : IObserver
    {
        public Office()
        {
            MessageBox.Show("Add Office");
        }

        public void update(int number)
        {
            MessageBox.Show("Office number : " + number);
        }
    }
}
