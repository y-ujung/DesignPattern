using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace State
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string[] unitAction = { "attack", "move" };
        private string[] unitState = { "normal", "lock down", "blind", "emergency" };
        private string curState = "Normal";

        public string[] UnitAction
        {
            get
            {
                return unitAction;
            }
            set
            {
                unitAction = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UnitAction"));
            }
        }

        public string[] UnitState
        {
            get
            {
                return unitState;
            }
            set
            {
                unitState = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UnitState"));
            }
        }

        public string CurState
        {
            get
            {
                return curState;
            }
            set
            {
                curState = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CurState"));
            }
        }


        public ICommand AttackCommand { get; set; }
        public ICommand MoveCommand { get; set; }
        public ICommand StateChangeCommand { get; set; }

        public ViewModel()
        {
            AttackCommand = new RelayCommand<object>(Attack);
            MoveCommand = new RelayCommand<object>(Move);
            StateChangeCommand = new RelayCommand<object>(StateChange);
        }

        private void StateChange(object obj)
        {
            string flag;

            if (obj is string)
                flag = obj as string;
            else
                flag = string.Empty;
            switch (flag)
            {
                case "0" :
                    Unit.INSTANCE.setState(Unit.INSTANCE.getNormal());
                    break;
                case "1" :
                    Unit.INSTANCE.setState(Unit.INSTANCE.getLockdown());
                    break;
                case "2" :
                    Unit.INSTANCE.setState(Unit.INSTANCE.getBlind());
                    break;
                case "3":
                    Unit.INSTANCE.setState(Unit.INSTANCE.getEmergency());
                    break;
            }
            CurState = Unit.INSTANCE.getState();
        }

        private void Attack(object obj)
        {
            Unit.INSTANCE.Attack();
        }

        private void Move(object obj)
        {
            Unit.INSTANCE.Move();
        }
    }
}
