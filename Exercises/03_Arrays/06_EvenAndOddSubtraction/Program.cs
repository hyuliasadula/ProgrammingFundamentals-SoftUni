﻿using System;
using System.Linq;

namespace _06_EvenAndOddSubtraction
{
    internal class Program
    {
        /*
         Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.

            Input               Output      Comments

            1 2 3 4 5 6           3         Even: 2 + 4 + 6 = 12 
                                            Odd: 1 + 3 + 5 = 9 
                                            Result: 12 – 9 = 3

            3 5 7 9              -24        Even: 0 
                                            Odd: 3 + 5 + 7 + 9 = 24 
                                            Result: 0 – 24 = -24

            2 4 6 8 10           30         Even: 2 + 4 + 6 + 8 + 10 = 30 
                                            Odd: 0 
                                            Result: 30 – 0 = 30
         
         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            int evenNumbers = 0;
            int oddNumbers = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers += numbers[i];
                }
                else
                {
                    oddNumbers+= numbers[i];
                }
            }
            int result = evenNumbers-oddNumbers;
            Console.WriteLine(result);
            
        }
    }
}
