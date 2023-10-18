using System;

namespace _01_SmallestOfThreeNumbers
{
    internal class Program
    {
        /*
         Create a method that prints out the smallest of three integer numbers.


        input     output
        2           2
        5
        3


        600         123
        342
        123


         
         */
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = MinNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int MinNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            return Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
        }
    }
}
