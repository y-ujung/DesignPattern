using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public string toppings;

        public void prepare()
        {
            recipe();
            if(wantCut())
            {
                cut();
            }

            addDrink();

        }


        public virtual Boolean wantCut()
        {
            return true;
        }

        public void recipe()
        {
            MessageBox.Show(name + "\n" + "dough : " + dough + "\n" + "sauce : " + sauce + "\n" + "toppings : " + toppings);
        }

        public abstract void cut();

        public abstract void addDrink();

    }
}
