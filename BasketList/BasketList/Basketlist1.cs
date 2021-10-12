using System;
using System.Collections.Generic;
using System.Text;

namespace BasketList
{
    class Basketlist1
    {
         private Fruit[] arr;
        public Basketlist1()
        {
            arr = new Fruit[0];
        }
        public void Add(Fruit fruit)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = fruit;
        }
        public Fruit[] GetArray()
        {
            return arr;
        }
        public int Count
        {
            get
            {
                return arr.Length;
            }
        }
    }
}
