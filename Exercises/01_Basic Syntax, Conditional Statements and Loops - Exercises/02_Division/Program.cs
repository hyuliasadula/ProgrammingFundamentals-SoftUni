using System;

namespace _02_Division
{
    internal class Program
    {

        /*You will be given an integer, write a program which checks if the given integer is divisible by 2 or 3, or 6, or 7, or 10 without a remainder. You should always take the bigger division:

        · If the number is divisible by both 2, 3, and 6, you should print the division by 6 only.

        · If a number is divisible by 2 and 10, you should print the division by 10.

        If the number is not divisible by any of the given numbers, print "Not divisible". Otherwise, print "The number is divisible by {number}".

        Examples

        Input    Output

        30      The number is divisible by 10 

        15      The number is divisible by 3

        12      The number is divisible by 6

        1643        Not divisible
        */
        static void Main(string[] args)
        {

            //enter a number
            int number = int.Parse(Console.ReadLine());


            //if its dividable by 10 enter
            if (number % 10 == 0)
            {
                //we check if its dividable by 2 too
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                }
                else
                {
                    Console.WriteLine("The number is divisible by 10");
                }

            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine("The number is divisible by 6");
                }
                else if(number % 2 == 0)
                {
                    Console.WriteLine("The number is divisible by 6");
                }

            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0) {
                
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            
        }
    }
}
