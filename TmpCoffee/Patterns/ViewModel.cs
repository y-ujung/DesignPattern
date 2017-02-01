using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Coffee
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string[] coffeenames = { "에스프레소", "아메리카노", "카페모카", "카라멜 마끼야또" };
        public string[] CoffeeNames
        {
            get { return coffeenames; }
            set
            {
                coffeenames = value;
                var handler = this.PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("CoffeeNames"));
                }
            }
        }

        private string curcoffee = "none";
        public string CurCoffee
        {
            get { return curcoffee; }
            set
            {
                curcoffee = value;
                var handler = this.PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("CurCoffee"));
                }
            }
        }

        public ICommand CoffeeSelectCommand { get; set; }

        public ViewModel()
        {
            CoffeeSelectCommand = new RelayCommand<object>(CoffeeSelect);
        }

        private void CoffeeSelect(object obj)
        {
            string name = obj as string;

            switch(name)
            {
                case "0":
                    CurCoffee = "4000원";
                    break;
                case "1":
                    CurCoffee = "4500원";
                    break;
                case "2":
                    CurCoffee = "5500원";
                    break;
                case "3":
                    CurCoffee = "6000원";
                    break;
            }
        }
    }
}

