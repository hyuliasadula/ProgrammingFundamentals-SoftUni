using System;

namespace _07_TheatrePromotion
{
    internal class Program
    {
        /*
         A theatre sails tickets at discount and a program is needed to calculate the price of a single ticket. If the given age does not fit one of the categories, you should print "Error!".

        The prices of the tickets are as follows:

        Day /       Age 0 <= age <= 18      18 < age <= 64       64 < age <= 122

        Weekday             12$                    18$                  12$

        Weekend             15$                    20$                  15$

        Holiday              5$                    12$                  10$
         
         */
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (typeOfDay == "Weekday")
            {
                if (age>=0 &&age <= 18)
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (age >18 && age <= 64)
                {
                    price = 18;
                    Console.WriteLine($"{price}$");
                }
                else if (age > 64 && age <= 122)
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                    Console.WriteLine($"{price}$");
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay ==  "Holiday")
            {
                if (age >= 0 && age <= 18)
                    {
                    price = 5;
                    Console.WriteLine($"{price}$");
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                    Console.WriteLine($"{price}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            

           
        }
    }
}
