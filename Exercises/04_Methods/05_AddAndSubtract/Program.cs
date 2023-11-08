using System;

namespace _05_AddAndSubtract
{
    internal class Program
    {
        /*
         * You will receive 3 integers. Create a method that returns the sum of the first two integers
         * and another method that subtracts the third integer from the result of the sum method.
         */

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber);
            int result = Subtract(thirdNumber, sum);

            Console.WriteLine(result);
        }

        private static int Sum(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        private static int Subtract(int thirdNumber, int sum)
        {
            int result = sum - thirdNumber;
            return result;
        }
    }
}
