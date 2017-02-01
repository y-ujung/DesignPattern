using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {

        #region Singleton

        private static NYPizzaStore NInstance = new NYPizzaStore();

        private NYPizzaStore()
        {
            MessageBox.Show("-Singleton-\nNYPizzaStore");
        }

        public static NYPizzaStore INSTANCE
        {
            get
            {
                return NInstance;
            }
        }
        #endregion

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza=null;

            if (type.Equals("cheese"))
            {
                pizza = new NYstyleCheesePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYstyleClamPizza();
            }

            return pizza;
        }
    }
}