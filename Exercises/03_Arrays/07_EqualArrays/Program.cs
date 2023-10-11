﻿using System;
using System.Linq;

namespace _07_EqualArrays
{
    internal class Program
    {
        /*
         Read two arrays and determine whether they are identical or not. The arrays are identical, if all their elements are equal. If the arrays are identical, find the sum of the elements of one of them and print the following message to the console: "Arrays are identical. Sum: {sum}"

        Otherwise, find the first index where the arrays differ and print the following message to the console: "Arrays are not identical. Found difference at {index} index"



                 Input                  Output

                10 20 30

                10 20 30            Arrays are identical. Sum: 60


                1 2 3 4 5

                1 2 4 3 5           Arrays are not identical. Found difference at 2 index



                1

                10                  Arrays are not identical. Found difference at 0 index
         */
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < firstArr.Length; i++)
                {
                
                    if (firstArr[i] != secondArr[i])
                    {
                            Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                            return;
                    }
                            sum += firstArr[i];
                }
            for (int i = 0; i < secondArr.Length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {

                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    break;
                }
            }
        }
    }
}
