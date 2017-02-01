using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace State
{
    public class LockDown : INormalState
    {
        public void Attack()
        {
            MessageBox.Show("LockDown : No Attack");
        }

        public string getState()
        {
            return "LockDown";
        }

        public void Move()
        {
            MessageBox.Show("LockDown : No Move");
        }
    }
}
