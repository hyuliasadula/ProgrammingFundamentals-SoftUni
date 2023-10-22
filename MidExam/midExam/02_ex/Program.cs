using System;

namespace _02_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vehicles = input.Split(new string[] { ">>" }, StringSplitOptions.None);
            decimal totalTaxCollected = 0;

            foreach (string vehicleData in vehicles)
            {
                string[] elements = vehicleData.Split(' ');

                if (elements.Length != 3)
                {
                    Console.WriteLine("Invalid car type.");
                    continue;
                }
                else
                {
                    string carType = elements[0];
                    int yearsForTax = int.Parse(elements[1]);
                    int kilometersTraveled = int.Parse(elements[2]);

                    decimal tax = CalculateTax(carType, yearsForTax, kilometersTraveled);
                    totalTaxCollected += tax;

                    if (IsCarTypeValid(carType))
                    {
                        Console.WriteLine($"A {carType} car will pay {tax:F2} euros in taxes.");
                    }
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTaxCollected:F2} euros in taxes.");
        }

        static bool IsCarTypeValid(string carType)
        {
            return carType == "family" || carType == "heavyDuty" || carType == "sports";
        }

        static decimal CalculateTax(string carType, int yearsForTax, int kilometersTraveled)
        {
            decimal initialTax = 0;
            decimal taxDeclinePerYear = 0;
            decimal taxIncreasePerKilometer = 0;

            switch (carType)
            {
                case "family":
                    initialTax = 50;
                    taxDeclinePerYear = 5;
                    taxIncreasePerKilometer = 12;
                    break;

                case "heavyDuty":
                    initialTax = 80;
                    taxDeclinePerYear = 8;
                    taxIncreasePerKilometer = 14;
                    break;

                case "sports":
                    initialTax = 100;
                    taxDeclinePerYear = 9;
                    taxIncreasePerKilometer = 18;
                    break;

                default:
                    Console.WriteLine("Invalid car type.");
                    return 0;
            }

            decimal tax = initialTax;

            // Calculate the tax decline based on years
            decimal yearsTaxDecline = yearsForTax * taxDeclinePerYear;
            tax -= yearsTaxDecline;

            // Calculate the tax increase based on kilometers traveled
            decimal kmTaxIncrease = 0;
            if (carType == "family")
            {
                kmTaxIncrease = kilometersTraveled / 3000 * taxIncreasePerKilometer;
            }
            else if (carType == "heavyDuty")
            {
                kmTaxIncrease = kilometersTraveled / 9000 * taxIncreasePerKilometer;
            }
            else if (carType == "sports")
            {
                kmTaxIncrease = kilometersTraveled / 2000 * taxIncreasePerKilometer;
            }

            tax += kmTaxIncrease;

            return tax;
        }
    }
}