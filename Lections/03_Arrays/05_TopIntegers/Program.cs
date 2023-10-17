using System;
using System.Linq;

namespace _05_TopIntegers
{
    internal class Program
    {
        /*
         Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.
                    input                         output
                1 4 3 2                          4 3 2
                14 24 3 19 15 17                 24 19 17
                27 19 42 2 13 45 48              48

         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            FindTopIntegers(numbers);

        }

        static void FindTopIntegers(int[] numbers)
        {
            int maxNumber = int.MinValue; 
            string topIntegers = "";

            // Start from the end of the array and move to the beginning
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNumber = numbers[i];

                // If the current number is greater than the maxNumber, it's a top integer
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                    topIntegers = currentNumber + " " + topIntegers;
                }
            }

            Console.WriteLine(topIntegers.Trim());
        }
    }
    
}
