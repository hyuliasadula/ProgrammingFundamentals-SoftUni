using System;
using System.Linq;

namespace _02_CommonElements
{
    internal class Program
    {
        /*
         Create a program that prints out all common elements in two arrays. You have to compare the elements of the
            second array to the elements of the first.

             Input                           Output
            Hey hello 2 4
            10 hey 4 hello
                                            4 hello

            S of t un i
            of i 10 un
                                            of i un

            i love to code
            code i love to
                                            code i love to
         */
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ').ToArray();
            string[] secondInput = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < secondInput.Length; i++)
            {
                for (int y = 0; y < firstInput.Length; y++)
                {
                    if (secondInput[i] == firstInput[y])
                    {
                        Console.Write(firstInput[y] + " ");
                        break;
                    }
                }
            }
        }
    }
}
