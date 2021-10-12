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
            proglan.Add(1994, "Java");
            proglan.Add(1995, "Php");
            proglan.Add(2012, "React");
            proglan.Add(1970, "SQL");
            Console.WriteLine("Proglamlashdirma dilleri ");
            foreach (DictionaryEntry item in proglan)
            {
                Console.WriteLine(item.Value);

            } 
            Console.WriteLine("**********");
            Console.WriteLine("Proqramlashdirma dilleri illere gore");
            foreach (DictionaryEntry item in proglan)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
