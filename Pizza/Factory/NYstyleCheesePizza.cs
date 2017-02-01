using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FactoryPattern
{
    public class NYstyleCheesePizza : Pizza
    {
        public NYstyleCheesePizza()
        {
            name = "NY style cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings = "Grated Reggiano Cheese";

        }

        public override void cut()
        {
            MessageBox.Show("Cutting");
        }

        public override void addDrink()
        {
            MessageBox.Show("Add Cola");
        }
    }
}
