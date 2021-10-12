﻿using System;

namespace Delegatehometask
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> action = Negative;
            action.Invoke(11569);
        }
        public static void Negative(int num)
        {
          int  count = 0;
            if (num < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Positive");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            for (int i = 2; i * i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Number is Complex");
            }
            else
            {
                Console.WriteLine("Number is Simple");
            }
        }
    } 
}
