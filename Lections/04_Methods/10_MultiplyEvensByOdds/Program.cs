using System;

namespace _10_MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            return EvenAndOddCalculations(number, isEven: false);
        }

        private static int GetSumOfEvenDigits(int number)
        {
            return EvenAndOddCalculations(number, isEven: true);
        }

        private static int EvenAndOddCalculations(int number, bool isEven)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                if ((digit % 2 == 0) == isEven)
                {
                    sum += digit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
