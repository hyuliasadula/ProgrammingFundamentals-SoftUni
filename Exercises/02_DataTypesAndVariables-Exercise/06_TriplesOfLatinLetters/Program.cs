using System;

namespace _06_TriplesOfLatinLetters
{
    internal class Program
    {
        /*
         * 
       input        output
         3 
                    aaa
                    aab
                    aac
                    aba
                    abb
                    abc
                    aca
                    acb
                    acc
                    baa
                    bab
                    bac
                    bba
                    bbb
                    bbc
                    bca
                    bcb
                    bcc
                    caa
                    cab
                    cac
                    cba
                    cbb
                    cbc
                    cca
                    ccb
                    ccc
         */
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < 'a' + numberOfLetters; first++)
            {
                for (char second = 'a'; second < 'a' + numberOfLetters; second++)
                {
                    for (char third = 'a'; third < 'a' + numberOfLetters; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
