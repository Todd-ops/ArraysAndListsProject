using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[] {1,2,3, 4, 5, 6, 7, 8, 9, 10};


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var even = new List<int>();
            var odd = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    even.Add(num);
                }
                else
                {
                    odd.Add(num);
                }
            }


            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Even numbers");
            
            for (int i = 0; i < even.Count; i++)
            {
                Console.WriteLine(even[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Odd Numbers");

            for (int t = 0; t < odd.Count; t++)
            {
                Console.WriteLine(odd[t]);
            }
            //or
            //foreach(var num in even)
            //{
            //    Console.WriteLine(num);
            //}

            
            
            
            

            
            

            

        }
    }
}
