using System;

namespace _02_PoundsToDollars
{
    internal class Program
    {
        /*
         Create a program that converts British pounds to US dollars formatted to the 3rd decimal point.
           1 British Pound = 1.31 Dollars


        input      output
        80          104.800

        39          51.090
         */
        static void Main(string[] args)
        {
            float pounds = float.Parse(Console.ReadLine());

            float onePoundToDollar = 1.31f;

            float dollars = pounds * onePoundToDollar;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
