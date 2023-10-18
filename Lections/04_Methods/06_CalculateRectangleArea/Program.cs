using System;

namespace _06_CalculateRectangleArea
{
    internal class Program
    {
        /*
         Create a method that calculates and returns the area of a rectangle
        Input Output
        3
        4
                12
        6
        2
                12

         
         
         */
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int area = AreaOfRectangle(firstNumber, secondNumber);
            Console.WriteLine(area);
        }

         static int AreaOfRectangle(int firstNumber, int secondNumber)
        {
           return firstNumber * secondNumber;
        }
    }
}
