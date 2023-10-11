
using System;

namespace _02_PrintNumbersInReverseOrder
{
    internal class Program
    {
        /*
          Read n numbers and print them in reverse order, separated by a single space.

         input        output
         3

        10
        20
        30           30 20 10


         */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numArr = new int[number];


            for (int i = 0; i < number; i++)
            {
                int digits = int.Parse(Console.ReadLine());
                numArr[i] =  digits;    
            }
            for (int i = numArr.Length - 1; i >= 0; i--)
            {
                Console.Write(numArr[i] + " ");
            }
        }
    }
}
