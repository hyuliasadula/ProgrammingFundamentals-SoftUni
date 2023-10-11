using System;

namespace _09_CharsToString
{
    internal class Program
    {
        /*
            Create a program that reads 3 lines of input. On each line, you get a single character. Combine all the characters into one string and print it on the console.

        a
        b
        c

        -> abc

         
         */
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

           string combined = first+ "" + second+ ""+third+"";
            Console.WriteLine(combined);
        }
    }
}
