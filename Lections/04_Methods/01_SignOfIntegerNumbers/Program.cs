using System;

namespace _01_SignOfIntegerNumbers
{
    internal class Program
    {

        /*
         A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result
                        print:
                        • For positive number: "The number {number} is positive. "
                        • For negative number: "The number {number} is negative. "
                        • For zero number: "The number {number} is zero. "

        Input            Output
        2                The number 2 is positive.
        -9               The number -9 is negative.

         */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);
        }

        static void CheckNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
