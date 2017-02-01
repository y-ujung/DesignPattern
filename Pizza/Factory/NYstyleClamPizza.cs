using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FactoryPattern
{
    public class NYstyleClamPizza : Pizza
    {
        public NYstyleClamPizza()
        {
            name = "NY style clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings = "Fresh Clams";

        }

        public override void cut()
        {
            MessageBox.Show("Cutting");
        }

        public override void addDrink()
        {
            MessageBox.Show("Add Lemonade");
        }
    }
}
