using System;

namespace _9_SumOfOddNumbers
{
    internal class Program
    {
        /*
         Create a program that prints on a new line the next n odd numbers (starting from 1). On the last row print the sum of all n odd numbers.

        Input

        A single number n is read from the console, indicating how many odd numbers need to be printed.

        Output

        Print the next n odd numbers, starting from 1, separated by new lines. On the last line, print the sum of these numbers.

        Constraints

        · n will be in the interval [1…100]

        5 ->    1 
                3 
                5 
                7 
                9 
                Sum: 25
         */
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;



            for (int i = 1; n > 0; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
                n--;
            }

            Console.WriteLine($"Sum: {sum}");















            //int n =int.Parse(Console.ReadLine());
            //int sum = 0;
            //int number = 0;

            //for (int i = 0; i < n; i++)
            //{

            //    number = int.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //Console.WriteLine($"Sum: {sum}");

        }
    }
}
