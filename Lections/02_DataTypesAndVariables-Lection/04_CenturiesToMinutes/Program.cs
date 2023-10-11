using System;

namespace _04_CenturiesToMinutes
{
    internal class Program
    {
        /*Create a program to enter an integer number of centuries and convert it to years, days, hours and minutes
         
         1     1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
         5     5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes

         */
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422); 
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days:F0} days = {hours:F0} hours = {minutes:F0} minutes");
        }
    }
    
}
