using System;

namespace _1_ConvertMetersToKilometers
{
    internal class Program
        /*You will be given an integer that will be a distance in meters. Create a program that converts meters to
            kilometers formatted to the second decimal point.

         input          output
         1852            1.85
         */
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double kilometers = meters / 1000;


            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
