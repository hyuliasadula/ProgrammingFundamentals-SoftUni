using System;

namespace _12_EvenNumber
{
    internal class Program
    {
        /*
         Create a program that reads a sequence of numbers. If the number is even, print its absolute value in the following format: "The number is: {number}" and terminate the program. If the number is odd, print "Please write an even number." and continue reading numbers.
         */
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
            }
        }
    }
}