using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgLangu_Collection_
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList proglan = new SortedList();
            proglan.Add(2000, "C#");
            proglan.Add(1991, "Python");
            proglan.Add(1995, "Java");
            proglan.Add(1994, "Php");
            SortedList proglan1 = new SortedList();
            proglan1.Add("C#", 2000);
            proglan1.Add("Python", 1991);
            proglan1.Add("Java", 1994);
            proglan1.Add("Php", 1995);
             



            Console.WriteLine("Proglamlashdirma dilleri Alfabetik ");
            foreach (DictionaryEntry item in proglan1)
            {
                Console.WriteLine(item.Key);

            }
            Console.WriteLine("Proqramlashdirma dilleri illere gore");
            foreach (DictionaryEntry item in proglan)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
