using System;

namespace _07_RepeatString
{
    internal class Program
    {
        /*
         Create a method that receives two parameters:
            • A string
            • A number n (integer) represents how many times the string will be repeated
            The method should return a new string, containing the initial one, repeated n times without space.


        input           output
        abc             abcabcabc
         3
         
         */
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int integer = int.Parse(Console.ReadLine());
            RepeatString(text, integer);
        }

        private static void RepeatString(string text, int integer)
        {
            for (int i = 0; i < integer; i++)
            {
                Console.Write(text);
            }
        }
    }
}
