using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
    public class ArrayListIterator : IIterator
    {
        ArrayList items;
        int num = 0;

        public ArrayListIterator(ArrayList items)
        {
            this.items = items;
        }
        public bool hasNext()
        {
            if (num < items.Count)
                return true;
            else
                return false;
        }

        public object next()
        {
            object item = items[num];
            num = num + 1;
            return item;
        }
    }
}