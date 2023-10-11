using System;
using System.Linq;

namespace _08_CondenseArrayToNumber
{
    internal class Program
    {
        /*Create a program to read an array of integers and condense them by summing all adjacent couples of elements until a single integer remains.

        For example, let us say we have 3 elements - {2, 10, 3}. We sum the first two and the second two elements and get {2 + 10, 10 + 3} = {12, 13}, then we sum all adjacent elements again. This results in {12 + 13} = {25}.
         
         Input          Output

        2 10 3          25 

        5 0 4 1 2       35 

        1                1
         
         

        Hints

        While we have more than one element in the array nums[], repeat the following:

        · Allocate a new array condensed[] of size nums.length.

        · Sum the numbers from nums[] to condensed[].

        o condensed[i] = nums[i] + nums[i+1]

        · nums[] = condensed[]
         
         */
        static void Main(string[] args)
        {
            int[] integersArray = Console.ReadLine()
                                        .Split(' ')
                                        .Select(int.Parse)
                                        .ToArray();

            // Continue condensing the array until only one element remains.
            while (integersArray.Length > 1)
            {
                // Create a new array, 'condensed,' to store the results of condensation.
                int[] condensed = new int[integersArray.Length - 1];

                // Iterate through the original array, summing adjacent elements and storing the result in the 'condensed' array.
                for (int i = 0; i < integersArray.Length - 1; i++)
                {
                    condensed[i] = integersArray[i] + integersArray[i + 1];
                }

                // Update the original array with the 'condensed' array.
                integersArray = condensed;
            }
            Console.WriteLine(integersArray[0]);
        }
    }
}
