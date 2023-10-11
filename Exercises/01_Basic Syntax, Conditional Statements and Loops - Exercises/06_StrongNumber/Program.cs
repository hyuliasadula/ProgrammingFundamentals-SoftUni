using System;

namespace _06_StrongNumber
{
    internal class Program
    {
        /*
         Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of the factorials of each digit is equal to the number itself.

        Example: 145 is a strong number, because 1! + 4! + 5! = 145.

        Print "yes", if the number is strong and "no", if the number is not strong


        Input Output

        2       yes

        3451     no

        40585    yes
         */

        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;
           

            for ( int i = 0; i < number.Length; i++)
            {
                int factoriel = 1;

                int currentNumber = int.Parse(number[i].ToString());

                for (int j = 1; j <= currentNumber; j++)
                {
                    factoriel *= j;
                }

                sum += factoriel;


            }

            if (sum == int.Parse(number)) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
            
        }
    }
}
