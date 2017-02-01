using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
    public class ArrayIterator : IIterator
    {
        Item[] items;
        int num = 0;
        public ArrayIterator(Item[] items)
        {
            this.items = items;
        }
        public Boolean hasNext()
        {
            if (num < items.Length)
                return true;
            else
                return false;
        }

        public object next()
        {
            Item item = items[num];
            num = num + 1;
            return item;
        }
    }
}