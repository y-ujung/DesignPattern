using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
    public class Item
    {
        string name;
        int cost;

        public Item(string n, int c)
        {
            name = n;
            cost = c;
        }

        public string getName()
        {
            return name;
        }

        public int getCost()
        {
            return cost;
        }
    }
}
