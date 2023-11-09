using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_GaussTrick
{
    internal class Program
    {
        /*
         Create a program that sums all numbers in a list in the following order:
        first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.


        Input           Output
        1 2 3 4 5       6 6 3
        1 2 3 4         5 5
         */
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int length = list.Count;

            for (int i = 0; i < length / 2; i++)
            {
                int sum = list[i] + list[length - 1 - i];
                Console.Write(sum + " ");

                // If the list has an odd number of elements
                if (length % 2 != 0 && i == length / 2 - 1)
                {
                    Console.Write(list[length / 2]);
                }
            }
        }
    }
}
