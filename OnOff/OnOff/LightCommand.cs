using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandPattern
{
    public class LightCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Light l = new Light();
            string flag;
            if (parameter is string)
                flag = parameter as string;
            else
                flag = string.Empty;

            switch (flag)
            {
                case "on":
                    l.on();
                    break;
                case "off":
                    l.off();
                    break;
            }
        }
    }
}
