using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace State
{
    class Emergency : IEmergencyState
    {
        public void Run()
        {
            MessageBox.Show("Emergency : Run");
        }

        public void Defense()
        {
            MessageBox.Show("Emergency : Defense");
        }

        public string getState()
        {
            return "Emergency";
        }
    }
}
