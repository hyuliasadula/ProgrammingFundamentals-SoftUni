using System;

namespace _09_PalindromeIntegers
{
    internal class Program
    {
        /*
         Create a program that reads positive integers until you receive the "END" command. For each number, print whether the number is a palindrome or not. A palindrome is a number that reads the same backward as forward, such as 323 or 1001.
        
        Input       Output
        123         false
        323         true
        421         false
        121         true
        END
         
         */
        static void Main(string[] args)
        {
            string numbers;
            while (true)
            {
                numbers = Console.ReadLine();
                Polindrome(numbers);
                if (numbers == "END") 
                {
                    return;
                }
            }
            
            
        }

        private static void Polindrome( string numbersStr)
        {
            int numbers = int.Parse(numbersStr);
            int  remainder, sum = 0, temp;
            temp = numbers;
            while (numbers > 0)
            {
                remainder = numbers % 10;
                sum = (sum * 10) + remainder;
                numbers = numbers / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
                
        }
    }
}
