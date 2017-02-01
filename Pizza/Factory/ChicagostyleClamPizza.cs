using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FactoryPattern
{
    public class ChicagostyleClamPizza : Pizza
    {
        public ChicagostyleClamPizza()
        {
            name = "Chicago style clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings = "Frozen Clams";

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
            MessageBox.Show("Add Lemonade");
        }
    }
}
