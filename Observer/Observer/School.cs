﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Observer
{
    public class School : IObserver
    {
        public School()
        {
            MessageBox.Show("Add School");
        }

        public void update(int number)
        {
            MessageBox.Show("School number : " + number);
        }
    }
}
