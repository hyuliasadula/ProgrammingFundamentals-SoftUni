using System;

namespace _08_MathPower
{
    internal class Program
    {
        /*
         Create a method, which receives two numbers as parameters:
            • The first number – the base
            • The second number – the power
            The method should return the base raised to the given power.


        Input Output
        2
        8
                256

        3
        4
                81

         
         */
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double sum =RaiseToPower(firstNumber, secondNumber);
            Console.WriteLine(sum); 

        }

        static double RaiseToPower(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}
