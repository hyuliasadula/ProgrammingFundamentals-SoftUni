using System;

namespace _04_PrintAndSum
{
    internal class Program
    {
        /*You will receive two whole numbers from the console representing the start and the end of a sequence of numbers.

        Your task is to print two lines:

        · On the first line, print all numbers from the start of the sequence to the end inclusive.

        · On the second line, print the sum of the sequence in the format: "Sum: {sum}".
        

        Input Output

        5

        10 ->   5 6 7 8 9 10 
                Sum: 45

        0

        26  ->  0 1 2 … 26 
                Sum: 351
         
         */
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
