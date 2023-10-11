using System;

class Program
{
    static int RoundAwayFromZero(double number)
    {
        if (number >= 0)
        {
            return (int)Math.Floor(number + 0.5);
        }
        else
        {
            return (int)Math.Ceiling(number - 0.5);
        }
    }

    static void Main()
    {
       
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(' ');

        

        foreach (string inputNumber in inputNumbers)
        {
            if (double.TryParse(inputNumber, out double number))
            {
                int roundedNumber = RoundAwayFromZero(number);
                Console.WriteLine($"{number} => {roundedNumber}");
            }
            
        }
    }
}
