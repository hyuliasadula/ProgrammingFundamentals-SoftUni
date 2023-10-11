using System;

namespace _07_WaterOverflow
{
    internal class Program
    {
        /*
         The input will be on two lines:
        • On the first line, you will receive n – the number of lines, which will follow.
        • On the next n lines, you will receive quantities of water, which you have to pour into the tank.
        Output
        Every time you do not have enough capacity in the tank to pour the given liters, print:
        Insufficient capacity!
        On the last line, print only the liters in the tank

        input               output
        5

        20
        100
        100
        100
        20

                    Insufficient capacity!
                    240

         */
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int quantitie = 0;
            int sumOfLiters = 0;

            for (int i = 0; i < numberOfLines ; i++)
            {
                quantitie = int.Parse(Console.ReadLine());
                sumOfLiters += quantitie;
                if (sumOfLiters >255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumOfLiters -= quantitie;
                    continue;
                }
                

            }
            Console.WriteLine(sumOfLiters);

        }
    }
}
