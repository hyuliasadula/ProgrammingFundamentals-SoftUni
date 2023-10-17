using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace _06_EqualSums
{
    internal class Program
    {

        /*
         Create a program that determines if an element exists in an array for which the sum of all elements to its left is equal to the sum of all elements to its right. If there are no elements to the left or right, their sum is considered to be 0. Print the index of the element that satisfies the condition or "no" if there is no such element.



             Input          Output          Comments
            1 2 3 3           2             At a[2] -> left sum = 3, right sum = 3
                                            a[0] + a[1] = a[3]
                                            
            1 2                 no          At a[0] -> left sum = 0, right sum = 2
                                            At a[1] -> left sum = 1, right sum = 0
                                            No such index exists

            1                   0           At a[0] -> left sum = 0, right sum = 0


            1 2 3               no          No such index exists


   10 5 5 99 3 4 2 5 1 1 4
                                3           At a[3] -> left sum = 20, right sum = 20
                                            a[0] + a[1] + a[2] = a[4] + a[5] + a[6] +
                                            a[7] + a[8] + a[9] + a[10]

         
         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            int index = EqualSumElements(numbers);
            

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }


        }
        static int EqualSumElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0, rightSum = 0;

               
                for (int leftIndex = 0; leftIndex < i; leftIndex++)
                {
                    leftSum += numbers[leftIndex];
                }

                // Calculate the sum of elements to the right of the current element
                for (int rightIndex = i + 1; rightIndex < numbers.Length; rightIndex++)
                {
                    rightSum += numbers[rightIndex];
                }

                // Check if the left and right sums are equal
                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return -1; // If no such element is found
        }
    }
}
