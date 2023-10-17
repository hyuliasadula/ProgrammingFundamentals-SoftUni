using System;
using System.Linq;

namespace _07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        /*
         Create a program that finds the longest sequence of equal elements in an array of integers. If several equal sequences are present in the array, print out the leftmost one
         

                Input                                   Output
                2 1 1 2 3 3 2 2 2 1                      2 2 2
                1 1 1 2 3 1 3 3                          1 1 1
                4 4 4 4                                  4 4 4 4
                0 1 1 5 2 2 6 3 3                         1 1

         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            EqualSequences(numbers);
        }

        static void EqualSequences(int[] numbers)
        {

            int currentLength = 1; 
            int maxLength = 1;   
            int longestElement = numbers[0]; 

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    longestElement = numbers[i];
                }
            }

            // Print the longest sequence
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(longestElement + " ");
            }
        }
    }
}
