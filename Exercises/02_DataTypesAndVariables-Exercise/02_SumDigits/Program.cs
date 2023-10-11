using System;

namespace _02_SumDigits
{
    internal class Program
    {
        /*
         Create a program that receives a single integer. Your task is to find the sum of its digits.
        For example: 12345 → 1 + 2 + 3 + 4 + 5 = 15
        Examples
        Input       Output
        245678       32
        97561        28
        543          12

         */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numbersSum = 0;
            
            while (number>0) 
            {
                int digit = number % 10;
                numbersSum += digit; 
                number /= 10;

            }
            Console.WriteLine(numbersSum);
            
        }
    }
}
