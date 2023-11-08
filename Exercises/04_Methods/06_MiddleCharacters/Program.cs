using System;
using System.Runtime.ExceptionServices;

namespace _06_MiddleCharacters
{
    internal class Program
    {
        /*
         You will receive a single string. Create a method that prints the character found at its middle. If the length of the string is even, there are two middle characters.
         */
        static void Main(string[] args)
        {
            string singleString = Console.ReadLine();
            PrintMiddleCharacters(singleString);
        }

        private static void PrintMiddleCharacters(string singleString)
        {
            int length = singleString.Length;

            if (length % 2 == 1) //there's only one middle character
            {
                
                int middleIndex = length / 2;
                char middleChar = singleString[middleIndex];
                Console.WriteLine(middleChar);
            }
            else //there are two
            {

                int fisrtMiddleIndex = (length - 1) / 2; // Calculate the index of the first middle character.
                int secondMiddleIndex = length / 2; // Calculate the index of the second middle character.
                int i = fisrtMiddleIndex;
                while (i <= secondMiddleIndex)
                {
                    char middleChar = singleString[i];
                    Console.Write(middleChar);
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}
