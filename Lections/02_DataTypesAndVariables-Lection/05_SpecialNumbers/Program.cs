using System;

namespace SpecialNumbers
{
    /*
     A number is special when its sum of digits is 5, 7 or 11.
Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is
special or not (True / False).


7 

1 -> False
2 -> False
3 -> False
4 -> False
5 -> True
6 -> False
7 -> True
     
     */
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isSpecial = IsSpecial(i);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }

        static bool IsSpecial(int n)
        {

            int sumOfDigits = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sumOfDigits += digit;
                n /= 10;
            }

            return (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
        }
    }
}
