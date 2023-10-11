using System;

namespace _08_DivisibleBy3
{
    internal class Program
    {

        /*Create a program, which prints all the numbers from 1 to 100, that are divisible by 3. You have to use a single for loop. The program should not receive input.*/
        static void Main(string[] args)
        {
            for (int i = 1; i <=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
