using System;
using System.Linq;

namespace _05_SumEvenNumbers
{
    internal class Program
    {

        /*
         Read an array from the console and sum only its even values.

        Input                   Output

        1 2 3 4 5 6                12

        3 5 7 9                     0

        2 4 6 8 10                  30
         
         */
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbersArr = numbers.Split(' ');

            int[] stringToInt = numbersArr.Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < stringToInt.Length; i++)
            {
                if (stringToInt[i] % 2 == 0)
                {
                    sum += stringToInt[i];
                }
            }

            Console.WriteLine(sum);

        }
    }
}
