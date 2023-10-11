using System;

namespace ex_04
{
    internal class Program
    {
        /*
         Every time John tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes". One day John was tired of waiting and decided he needed a program, which prints the time after 30 minutes, so he could come back after exactly 30 minutes. He is not able to write the program by himself, so he asks for help.

            Input

            Two numbers are read from the console:

            · The first number is hours and will be between 0 and 23.

            · The second number is minutes and will be between 0 and 59

        Print on the console the time after 30 minutes. The result should be in format hh:mm. The hours may contain one or two numbers and the minutes always have two numbers (with leading zero).

       

        1
        46 -> 2:16 
        
        0 
        01 -> 0:31 
        
        23
        59 -> 0:29 
        
        11 
        08 - >11:38 

        Hints

        · Add 30 minutes to the initial minutes, which you receive from the console. If the minutes are more than 59, increase the hours by 1 and decrease the minutes by 60. In the same way, check if the hours are more than 23. When you print check for leading zero.
         */
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
           

            
            if (minutes > 59) 
            { 
              hours += 1;
              minutes -= 60; 
            }

            if (hours >23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
            
        }
    }
}
