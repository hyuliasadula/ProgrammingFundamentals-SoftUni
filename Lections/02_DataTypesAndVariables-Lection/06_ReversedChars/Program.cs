using System;

namespace _06_ReversedChars
{
    internal class Program

    /*  Create a program that takes 3 lines of characters and prints them in reversed order with a space between them
     
     A
     B
     C
    
     C B A
    */
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.Write($"{thirdLetter} {secondLetter} {firstLetter}");
        }
    }
}
