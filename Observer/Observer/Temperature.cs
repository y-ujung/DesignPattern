﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Observer
{
    public class Temperature : IObservable
    {
        private int number;
        private List<IObserver> oList;

        public Temperature(int number)
        {
            oList = new List<IObserver>();
            this.number = number;
            MessageBox.Show("Add Temperature");
        }

        public int getData()
        {
            return number;
        }

        public void NotifyObserver()
        {
            for(int i=0; i< oList.Count; i++)
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
