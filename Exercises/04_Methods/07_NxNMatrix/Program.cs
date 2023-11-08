using System;

namespace _07_NxNMatrix
{
    internal class Program
    {
        /*
         Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.

        ex:

         7      7 7 7 7 7 7 7
                7 7 7 7 7 7 7
                7 7 7 7 7 7 7
                7 7 7 7 7 7 7
                7 7 7 7 7 7 7
                7 7 7 7 7 7 7
                7 7 7 7 7 7 7

        3       3 3 3
                3 3 3
                3 3 3

         
         */
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int integerLength = integer;
            Matrix(integer);
        }

        private static void Matrix(int integer)
        {

            for (int i = 0; i < integer; i++)
            {
                for (int j = 0; j < integer; j++)
                {
                    Console.Write(integer + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
