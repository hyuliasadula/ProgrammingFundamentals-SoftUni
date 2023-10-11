using System;

namespace _03_Vacation
{
    internal class Program
    {

        /*
         You will receive three lines from the console
         · A count of people who are going on vacation.

            · Type of the group (Students, Business or Regular).

            · The day of the week which the group will stay on (Friday, Saturday or Sunday).

            Based on the given information calculate how much the group will pay for the entire vacation.

            The price for a single person is as follows:


                Friday      Saturday   Sunday

        Students  8.45       9.80     10.46

        Business  10.90      15.60      16

        Regular    15        20       22.50


                There are also discounts based on some conditions:

        · For Students – if the group is 30 or more people, you should reduce the total price by 15%.

        · For Business – if the group is 100 or more people, 10 of the people stay for free.

        · For Regular – if the group is between 10 and 20 people (both inclusively), reduce the total price by 5%.

        Note: You should reduce the prices in that EXACT order!

        As an output print the final price which the group is going to pay in the format:

        "Total price: {price}"

        The price should be formatted to the second decimal point.

         */
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;

            if (dayOfTheWeek == "Friday")
            {
                if (typeOfTheGroup == "Students")
                {
                    if (countOfPeople >= 30)
                    {
                        price = (countOfPeople * 8.45) * 0.85;
                    }
                    else
                    {
                        price = countOfPeople * 8.45;
                    }
                    
                }
                else if (typeOfTheGroup == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                        price = countOfPeople * 10.90;
                    }
                    else
                    {
                        price = countOfPeople * 10.90;
                    }
                    
                }
                else
                {
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price = (countOfPeople * 15) * 0.95;
                    }
                    else { price = countOfPeople *  15; }
                    
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                if (typeOfTheGroup == "Students")
                {
                    if (countOfPeople >= 30)
                    {
                        price = (countOfPeople * 9.80) * 0.85;
                    }
                    else
                    {
                        price = countOfPeople * 9.80;
                    }

                }
                else if (typeOfTheGroup == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                        price = countOfPeople * 15.60;
                    }
                    else
                    {
                        price = countOfPeople* 15.60;
                    }
                }
                else
                {
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price = (countOfPeople * 20) * 0.95;
                    }
                    else
                    {
                        price = countOfPeople* 20;
                    }
                }
            }
            else 
            {
                if (typeOfTheGroup == "Students")
                {
                    if (countOfPeople >= 30)
                    {
                        price = (countOfPeople * 10.46) * 0.85 ;
                    }
                    else
                    {
                        price = countOfPeople * 10.46;
                    }
                    
                }
                else if (typeOfTheGroup == "Business")
                {
                    if (countOfPeople >= 100)
                    {
                        countOfPeople -= 10;
                        price = countOfPeople * 16;
                    }
                    else
                    {
                        price = countOfPeople* 16;
                    }
                }
                else
                {
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price = (countOfPeople * 22.50) * 0.95;
                    }
                    else
                    {
                        price = countOfPeople* 22.50;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
