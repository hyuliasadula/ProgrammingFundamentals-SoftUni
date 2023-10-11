using System;
using System.Text;

namespace _04_SumOfChars
{
    internal class Program
    {
        /*
         Create a program, which sums the ASCII codes of n characters and prints the sum on the console.
        Input
        • On the first line, you will receive n – the number of lines, which will follow.
        • On the next n lines – you will receive letters from the Latin alphabet.
        Output
        Print the total sum in the following format:
        "The sum equals: {totalSum}"
        Constraints
        • n will be in the interval [1…20].
        • The characters will always be either upper or lower-case letters from the English alphabet.
        • You will always receive one letter per line.


        5

        A
        b
        C
        d
        E
        The sum equals: 399
         */
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            char letters = '\0';
            int totalSum = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                letters = char.Parse(Console.ReadLine());
                int asciiValue = (int)letters;
                totalSum += asciiValue;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
