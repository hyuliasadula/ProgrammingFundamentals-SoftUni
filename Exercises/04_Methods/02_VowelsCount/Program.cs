using System;
using System.Linq;

namespace _02_VowelsCount
{
    internal class Program
    {
        /*
         Create a method that receives a single string and prints out the number of vowels contained in it.


        SoftUni      3
        Cats         1
        JS           0
         
         */
        static void Main(string[] args)
        {
            string[] singleString = Console.ReadLine().Split().ToArray();
            int vowelCount = CountVowels(singleString);
            Console.WriteLine(vowelCount);
        }

        private static int CountVowels(string[] singleString)
        {
            int vowelCounter = 0;
            foreach (string word in singleString)
            {
                foreach (char c in word)
                {
                    if (c == 'a' || c == 'A' ||
                        c == 'o' || c == 'O' ||
                        c == 'u' || c == 'U' ||
                        c == 'e' || c == 'E' ||
                        c == 'i' || c == 'I')
                    {
                        vowelCounter++;
                    }
                }
            }

            return vowelCounter;
        }
    }
}
