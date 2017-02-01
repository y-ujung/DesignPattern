using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObservable
    {
        void NotifyObserver();
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);

        void setData(int number);
        int getData();

    }
}
