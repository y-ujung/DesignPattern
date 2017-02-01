using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {

        #region Singleton

        private static volatile ChicagoPizzaStore CInstance = new ChicagoPizzaStore();

        private ChicagoPizzaStore()
        {
            MessageBox.Show("-Singleton-\nChicagoPizzaStore");
        }
        
        public static ChicagoPizzaStore INSTANCE
        {
            get
            {
                return CInstance;
            }
        }
        #endregion

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new ChicagostyleCheesePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ChicagostyleClamPizza();
            }

            return pizza;
        }
    }
}