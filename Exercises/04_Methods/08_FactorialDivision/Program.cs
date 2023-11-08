using System;

namespace _08_FactorialDivision
{
    internal class Program
    {
        /*
        Read two integers. Calculate the factorial of each number. Divide the first result by the second and print the result of the division formatted to the second decimal point.

       Input       Output 
           5       60.00
           2
        */
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            long firstFactorial = Factorial(firstNum);
            long secondFactorial = Factorial(secondNum);

            double result = (double)firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }

        static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
