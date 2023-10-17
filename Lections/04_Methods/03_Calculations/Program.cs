using System;

namespace _03_Calculations
{
    internal class Program
    {
        /*Create a program that receives three lines of input:
        • On the first line – a string – "add", "multiply", "subtract", "divide".
        • On the second line – a number.
        • On the third line – another number.
        You should create four methods (for each calculation) and invoke the corresponding method depending on the
        command. The method should also print the result (needs to be void).
        
         
         Input            Output
        subtract
        5
        4
                            1

        divide
        8
        4
                            2
        */
        static void Main(string[] args)
        {
            string arithmeticSigns = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            AritmeticsSum(arithmeticSigns, firstNumber, secondNumber);


            
        }
        static void AritmeticsSum(string arithmeticSigns, int firstNumber, int secondNumber)
        {
            if (arithmeticSigns == "add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (arithmeticSigns == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (arithmeticSigns == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
            else if (arithmeticSigns == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }
        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }

        static void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }

        static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        static void Divide(int a, int b)
        {
           
                int result = a / b;
                Console.WriteLine(result);
            
        }

    }
}
