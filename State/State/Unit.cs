using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Unit
    {
        INormalState normal;
        INormalState lockdown;
        INormalState blind;
        INormalState emergency;

        INormalState state;

        private static Unit UINSTANCE = new Unit();
        
        private Unit()
        {
            normal = new Normal();
            lockdown = new LockDown();
            blind = new Blind();
            emergency = new EmergencyAdapter(new Emergency());

            state = normal;
        }

        public INormalState getNormal()
        {
            return normal;
        }
        public INormalState getLockdown()
        {
            return lockdown;
        }
        public INormalState getBlind()
        {
            return blind;
        }
        public INormalState getEmergency()
        {
            return emergency;
        }

        public static Unit INSTANCE
        {
            get
            {
                return UINSTANCE;
            }
        }

        public void setState(INormalState state)
        {
            this.state = state;
        }
        public string getState()
        {
            return state.getState();
        }

        public void Attack()
        {
            state.Attack();
        }

        public void Move()
        {
            state.Move();
        }
    }
}
