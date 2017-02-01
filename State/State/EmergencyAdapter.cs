using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class EmergencyAdapter : INormalState
    {
        Emergency e;

        public EmergencyAdapter(Emergency e)
        {
            this.e = e;
        }

        public void Attack()
        {
            e.Defense();
        }

        public string getState()
        {
            return e.getState();
        }

        public void Move()
        {
            e.Run();
        }
    }
}
