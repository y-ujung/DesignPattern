using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FactoryPattern
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string[] pizza = { "NY Cheese Pizza", "NY Clam Pizza", "Chicago Cheese Pizza", "Chicago Clam Pizza"};
        private string[] option = { "Add drink", "Cut pizza" };

        public string[] Pizza
        {
            get { return pizza; }
            set
            {
                pizza = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Pizza"));
            }
        }

        public string[] Option
        {
            get { return option; }
            set
            {
                pizza = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Option"));
            }
        }

        private string type="";
        private string store="";

        public ICommand PizzaSelectCommand { get; set; }
        public ICommand OptionCheckCommand { get; set; }
        public ICommand OrderCommand { get; set; }

        public ViewModel()
        {
            PizzaSelectCommand = new RelayCommand<object>(PizzaSelect);
            OptionCheckCommand = new RelayCommand<object>(OptionCheck);
            OrderCommand = new RelayCommand<object>(Order);
        }

        private void OptionCheck(string name)
        {
            switch (name)
            {
                case "CutPizza":

                    break;
            }
        }

        private void PizzaSelect(object obj)
        {
            string name="";
            if (obj is string)
                name = obj as string;
            else
                name = string.Empty;

            switch (name)
            {
                case "0":
                    store = "NY";
                    type = "cheese";
                    break;
                case "1":
                    store = "NY";
                    type = "clam";
                    break;
                case "2":
                    store = "Chicago";
                    type = "cheese";
                    break;
                case "3":
                default :
                    store = "Chicago";
                    type = "clam";
                    break;
            }
        }

        private void Order(object obj)
        {
            if (store.Equals("NY"))
                NYPizzaStore.INSTANCE.OrderPizza(type);
            else
                ChicagoPizzaStore.INSTANCE.OrderPizza(type);
        }
    }
}
