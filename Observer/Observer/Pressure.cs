using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Observer
{
    public class Pressure : IObservable
    {
        private int number;
        private List<IObserver> oList;

        public Pressure(int number)
        {
            oList = new List<IObserver>();
            this.number = number;
            MessageBox.Show("Add Pressure");
        }

        public int getData()
        {
            return number;
        }

        public void NotifyObserver()
        {
            for (int i = 0; i < oList.Count; i++)
            {
                IObserver o = oList[i];
                o.update(number);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            oList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            //  oList.Remove(o);
        }

        public void setData(int number)
        {
            this.number = number;
            NotifyObserver();
        }
    }
}
