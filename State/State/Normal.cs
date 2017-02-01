using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace State
{
    class Normal : INormalState
    {
        public void Attack()
        {
            MessageBox.Show("Normal : Attack");
        }

        public string getState()
        {
            return "Normal";
        }

        public void Move()
        {
            MessageBox.Show("Normal : Move");
        }
    }
}
