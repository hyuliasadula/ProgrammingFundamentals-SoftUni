using System;
using System.Dynamic;

namespace _11_MathOperations
{
    internal class Program
    {
        /*
         Write a method that receives two numbers and an operator, calculates the result and returns it. You will be given
            three lines of input. The first will be the first number, the second one will be the operator and the last one will be
            the second number.
            The possible operators are: /, *, + and -.


        Input            Output
        5
        *
        5
                          25


        4
        +
        8
                         12


         
         
         */
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            Calculate(firstNumber, operation, secondNumber);
        }

        private static void Calculate(int firstNumber, string operation, int secondNumber)
        {

            int result = 0;
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine(result);
            }
            else if (operation == "-")
            {
                result= firstNumber - secondNumber;
                Console.WriteLine(result);
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine(result);
            } 
            else // -> /
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
        }
    }
}
