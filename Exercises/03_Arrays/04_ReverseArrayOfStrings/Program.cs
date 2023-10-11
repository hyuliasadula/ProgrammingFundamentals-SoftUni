using System;
using System.Linq;

namespace _04_ReverseArrayOfStrings
{
    internal class Program
    {
        /*
         Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence of space-separated strings. Print the output on a single line (space separated)

                Input             Output

            a b c d e            e d c b a

            -1 hi ho w           w ho hi -1
         
         */
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ').ToArray();

            string[] reversedArray = new string[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                reversedArray[i] = strArr[strArr.Length - 1 - i];
            }

            string reversedString = string.Join(" ", reversedArray);

            Console.WriteLine(reversedString);
        }
    }
}
