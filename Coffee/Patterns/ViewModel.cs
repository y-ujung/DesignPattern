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

namespace DecoratorPattern
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string[] coffeenames = { "ESPRESSO/4000", "DARK ROAST/5000" };
        private string[] condinames = { "MOCHA/500", "SOY/700", "WHIP/300" };

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
        

        public string[] CondimentNames
        {
            get { return condinames; }
            set
            {
                condinames = value;
                var handler = this.PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("CondimentNames"));
                }

            }
        }



        public ICommand OrderCommand { get; set; }
        public ICommand CoffeeSelectCommand { get; set; }
        public ICommand CondimentCheckCommand { get; set; }
        

        
        private BeverageFactory.BEVERAGE_TYPE CurBeverage;
        private List<BeverageFactory.CONDIMENT_TYPE> CurCondimentList = new List<BeverageFactory.CONDIMENT_TYPE>();


        public ViewModel()
        {
            OrderCommand = new RelayCommand<object>(Order);

            CoffeeSelectCommand = new RelayCommand<object>(CoffeeSelect);
            CondimentCheckCommand = new RelayCommand<object>(CondimentsCheck);
        }

        private void CondimentsCheck(object obj)
        {
            if(obj is CheckBox)
            {
                CheckBox cb = obj as CheckBox;
                if (cb.IsChecked == true)
                {
                    CurCondimentList.Add(this.GetCondiemntType(cb.Name));
                }
                else
                {
                    if (CurCondimentList.Contains(this.GetCondiemntType(cb.Name)))
                        CurCondimentList.Remove(this.GetCondiemntType(cb.Name));
                }
            }
        }


        private BeverageFactory.CONDIMENT_TYPE GetCondiemntType(string name)
        {
            switch (name)
            {
                case "Mocha":
                    return BeverageFactory.CONDIMENT_TYPE.MOCHA;
                case "Soy":
                    return BeverageFactory.CONDIMENT_TYPE.SOY;
                case "Whip":
                    return BeverageFactory.CONDIMENT_TYPE.WHIP;
                default:
                    return BeverageFactory.CONDIMENT_TYPE.MOCHA;
            }
        }

        private void CoffeeSelect(object obj)
        {
            string name = obj as string;

            switch(name)
            {
                case "0":
                    CurBeverage = BeverageFactory.BEVERAGE_TYPE.ESPRESSO;
                    break;
                case "1":
                    CurBeverage = BeverageFactory.BEVERAGE_TYPE.DRAKROAST;
                    break;
            }
        }

        private void Order(object obj)
        {
            Beverage b = BeverageFactory.INSTANCE.MakeBeverage(CurBeverage, CurCondimentList);
            MessageBox.Show(b.getDescription() + "\n" + b.cost() +" 원");
        }
    }
}

