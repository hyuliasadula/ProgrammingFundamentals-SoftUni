using System;
using System.Linq;

namespace _08_MagicSum
{
    internal class Program
    {
        /*
         Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number

                Input                           Output
                1 7 6 2 19 23
                8
                                                1 7
                                                6 2


                14 20 60 13 7 19 8
                27
                                                14 13
                                                20 7
                                                19 8
         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int uniqueNumber = int.Parse(Console.ReadLine());

            MagicSum(numbers, uniqueNumber);
        }

        private static void MagicSum(int[] numbers, int uniqueNumber)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int u = i + 1; u < numbers.Length; u++)
                {
                    if (numbers[i] + numbers[u] == uniqueNumber)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[u]}");
                    }
                }
            }
        }
    }
}
