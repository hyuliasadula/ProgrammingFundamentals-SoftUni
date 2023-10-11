using System;

namespace _03_ExactSumOfRealNumbers
{
    internal class Program
    {
        /*
         Create a program to enter n numbers and calculate and print their exact sum (without rounding).
        Examples
        Input                                           Output
        3
        1000000000000000000
        5
        10
                                                        1000000000000000015
        2
        0.00000000003
        333333333333.3                                  333333333333.30000000003
         
         
         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
