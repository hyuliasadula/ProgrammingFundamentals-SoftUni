using System;
using System.Linq;

namespace _04_ArrayRotation
{
    internal class Program
    {
        /*
          Create a program that receives an array and several rotations that you have to perform. The rotations are done by moving the first element of the array from the front to the back. Print the resulting array

              Input                      Output
             51 47 32 61 21
             2
                                         32 61 21 51 47


             32 21 61 1
             4
                                          32 21 61 1


             2 4 15 31
             5
                                          4 15 31 2
          */
        static void Main(string[] args)
        {
            int[] arrOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = arrOfNumbers.Length;
            int rotation = int.Parse(Console.ReadLine());


            int[] rotatedArr = new int[len];

            for (int i = 0; i < len; i++)
            {
                // Calculate the new position for each element after rotation
                int newPosition = (i - rotation + len) % len;

                // Store the element in the new position in the rotated array
                rotatedArr[newPosition] = arrOfNumbers[i];
            }

            // Print the rotated array
            foreach (int num in rotatedArr)
            {
                Console.Write(num + " ");
            }
        }
    }
}