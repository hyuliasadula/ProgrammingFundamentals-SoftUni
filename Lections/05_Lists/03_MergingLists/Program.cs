using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingLists
{
    internal class Program
    {
        /*
         You are going to receive two lists of numbers. Create a list that contains the numbers from both of the lists. The first element should be from the first list, the second from the second list, and so on. If the length of the two lists is not equal, just add the remaining elements at the end of the list.


        Input                              Output
        3 5 2 43 12 3 54 10 23             3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
        76 5 34 2 4 12
         */
        static void Main(string[] args)
        {
            List<int> firstListOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondListOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < firstListOfNumbers.Count; i++)
            {
                Console.Write(firstListOfNumbers[i]);
                for (int y = 0; y < secondListOfNumbers.Count; y++)
                {
                    Console.Write(secondListOfNumbers[y]);
                    continue;
                }
            }

        }
    }
}
