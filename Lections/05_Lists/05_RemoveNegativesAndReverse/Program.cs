using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_RemoveNegativesAndReverse
{
    internal class Program
    {
        /*
         Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. If there are no elements left in the list, print "empty".
         

        Input                    Output
        10 -5 7 9 -33 50        50 9 7 10
        7 -2 -10 1              1 7
        -1 -2 -3                empty
         */
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Remove negative numbers
            listOfNumbers.RemoveAll(num => num < 0);


            if (listOfNumbers.Count > 0)
            {
                listOfNumbers.Reverse();
                Console.WriteLine(string.Join(" ", listOfNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
