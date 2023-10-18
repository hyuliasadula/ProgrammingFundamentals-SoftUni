using System;

namespace _03_CharactersInRange
{
    internal class Program
    {
        /*
         Create a method that receives two characters and prints all the characters between them according to ASCII (on a
            single line).
            NOTE: If the second letter's ASCII value is less than that of the first one, then the two initial letters should be
            swapped.
         
       input                        output
        #
        :
                        $ % & ' ( ) * + , - . / 0 1 2 3 4 5 6 7 8 9
         */
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharactersBetween(firstChar, secondChar);
        }

        private static void PrintCharactersBetween(char firstChar, char secondChar)
        {
            if (secondChar < firstChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            // Initialize the loop variable 'c' to the character following 'firstChar'
            char c = (char)(firstChar + 1);

            // Continue the loop as long as 'c' is less than 'secondChar - 1'
            while (c < secondChar )
            {
                // Print the current character followed by a space
                Console.Write(c + " ");

                // Move to the next character
                c = (char)(c + 1);
            }
            Console.WriteLine();
        }
    }
}
