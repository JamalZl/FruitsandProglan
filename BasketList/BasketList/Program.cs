using System;
using System.Collections;
using System.Collections.Generic;

namespace BasketList
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Apple:","C,B6");
            Fruit fruit1 = new Fruit("Pineapple:","C,Calcium");
            Fruit fruit2 = new Fruit("Lemon:","C,A,B1");
            Fruit fruit3 = new Fruit("Pomegranate:","C,K,Potassium");
            Fruit fruit4 = new Fruit("Grape:", "C, beta-carotene, quercetin, lutein");
            Basketlist1 basketlist = new Basketlist1();
            basketlist.Add(fruit);
            basketlist.Add(fruit1);
            basketlist.Add(fruit2);
            basketlist.Add(fruit3);
            basketlist.Add(fruit4);
            Console.WriteLine($"Fruit count:{basketlist.Count}");
            Console.WriteLine("Fruit and their vitamins");
            foreach (var item in basketlist.GetArray())
            {
                Console.WriteLine(item.Vitamin + " " +item.Name);
            }
        }
    }
}
