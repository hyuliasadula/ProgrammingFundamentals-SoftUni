using System;

namespace _10_LowerOrUpper
{
    internal class Program
    {
        /*Create a program that prints whether a given character is upper-case or lower case.
         
         f lower-case
         F upper-case
        */
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            // 65 to 90 are the upper case letters
            if (letter >= 65 && letter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
