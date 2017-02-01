using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
    public class ArrayClass
    {
        Item[] items;
        int num = 0;

        public ArrayClass()
        {
            items = new Item[3];

            addItem("과자", 1500);
            addItem("아이스크림", 1200);
            addItem("빵", 800);

        }

        public void addItem(string s, int i)
        {
            Item item = new Item(s, i);
            
            if(num < 3)
            {
                items[num] = item;
                num++;
            }
        }

        public IIterator createIterator()
        {
            return new ArrayIterator(items);
        }
    }
}