using System;

namespace _12_RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //int takova = 0;
            //bool isSpecial = false;
            //for (int i = 1; i <= number; i++)
            //{
            //    int sum = 0;
            //    while (i > 0)
            //    {
            //        sum += i % 10;
            //        i = i / 10;
            //    }
            //    isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            //    Console.WriteLine($"{i} -> {isSpecial}");

            //    i = takova;
            //}

            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                int numbersCount = i;
                int sumOfDigits = 0;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }

                bool isSpecial = false;
                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{numbersCount} -> {isSpecial}");
                sumOfDigits = 0;
                i = numbersCount;
            }


        }
    }
}
