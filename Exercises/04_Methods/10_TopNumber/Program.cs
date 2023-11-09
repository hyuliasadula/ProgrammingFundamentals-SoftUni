using System;

namespace _10_TopNumber
{
    internal class Program
    {
        /*
         A top number is an integer that holds the following properties:

        • Its sum of digits is divisible by 8, e.g. 8, 17, 88
        • Holds at least one odd num, e.g. 232, 707, 87578
        • Some examples of top numbers are: 17, 161, 251, 4310, 123200
        Create a program to print all top numbers in the range [1…num].
        You will receive a single integer from the console, representing the end value.

         */
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());

            PrintTopNumbers(num);
        }
        static void PrintTopNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsTopNumber(int num)
        {
            // Sum of digits
            int sumOfDigits = 0;
            string numString = num.ToString();
            for (int i = 0; i < numString.Length; i++)
            {
                int digit = int.Parse(numString[i].ToString());
                sumOfDigits += digit;
            }


            // Check if the sum of digits is divisible by 8
            if (sumOfDigits % 8 == 0)
            {
                // Check if the number contains at least one odd num
                foreach (char digitChar in num.ToString())
                {
                    int digit = int.Parse(digitChar.ToString());
                    if (digit % 2 != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
