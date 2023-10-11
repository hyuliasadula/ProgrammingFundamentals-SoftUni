using System;
using System.Runtime.CompilerServices;

namespace _01_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enter a number in range 1-7 and print out the word representing it or "Invalid Day!". Use an array of strings.

            int theNumberOfDay = int.Parse(Console.ReadLine());

            
            string[] namesOfTheDays =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (theNumberOfDay>=1 && theNumberOfDay <=7)
            {
                // Subtract 1 from the input to match the array index (arrays are zero-based).
                string dayName = namesOfTheDays[theNumberOfDay - 1];
                Console.WriteLine(dayName);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
