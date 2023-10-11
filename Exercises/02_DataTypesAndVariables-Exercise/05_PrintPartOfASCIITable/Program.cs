using System;

namespace _05_PrintPartOfASCIITable
{
    internal class Program
    {
        /*
         Find online more information about ASCII (American Standard Code for Information Interchange) and write a
        program that prints part of the ASCII table of characters at the console. On the first line of input, you will receive
        the char index you should start with, and on the second line - the index of the last character you should print.
         */
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                char character = (char)i;
                Console.Write(character + " ");
            }
        }
    }
}
