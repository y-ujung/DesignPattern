using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IteratorProject
{
    public class SuperMarket
    {
        ArrayClass array;
        ArrayListClass arraylist;

        public SuperMarket(ArrayClass array, ArrayListClass arraylist)
        {
            this.array= array;
            this.arraylist= arraylist;
        }

        public void print()
        {
            IIterator a = array.createIterator();
            IIterator al = arraylist.createIterator();
            printmenu(a);
            printmenu(al);
        }

        private void printmenu(IIterator i)
        {
            while(i.hasNext())
            {
                Item item = (Item)i.next();
                MessageBox.Show(item.getName() + "::::::" + item.getCost());
            }
        }
    }
}
