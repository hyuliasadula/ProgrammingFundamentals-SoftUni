using System;
using System.Drawing;

namespace _04_PrintingTriangle
{
    internal class Program
    {
        /*
         Create a method for printing triangles as shown below:
                
        input     output
        3   
                    1
                    1 2
                    1 2 3
                    1 2
                    1

         */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TriangleMaking(number);
        }

        static void TriangleMaking(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                
                Console.WriteLine();
            }
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
