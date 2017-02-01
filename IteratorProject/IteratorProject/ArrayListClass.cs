using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
    public class ArrayListClass
    {
        ArrayList items;

        public ArrayListClass()
        {
            items = new ArrayList();

            addItem("우유", 1000);
            addItem("바나나", 700);
        }

        public void addItem(string s, int i)
        {
            Item item = new Item(s, i);
            items.Add(item);
        }

        public IIterator createIterator()
        {
            return new ArrayListIterator(items);
        }
    }
}
