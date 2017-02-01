using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;


namespace FactoryPattern
{
    public class ChicagostyleCheesePizza : Pizza
    {
        public ChicagostyleCheesePizza()
        {
            name = "Chicago style cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings = "Mozzarella Cheese";

        }
        public override Boolean wantCut()
        {
            return false;
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
