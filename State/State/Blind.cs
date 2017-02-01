using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace State
{
    public class Blind : INormalState
    {
        public void Attack()
        {
            MessageBox.Show("Blind : Attack");
        }

        public string getState()
        {
            return "Blind";
        }

        public void Move()
        {
            MessageBox.Show("Blind : No Move");
        }
    }
}
