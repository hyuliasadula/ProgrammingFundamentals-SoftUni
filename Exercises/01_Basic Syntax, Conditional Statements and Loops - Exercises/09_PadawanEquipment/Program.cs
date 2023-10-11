using System;

namespace _09_PadawanEquipment
{
    internal class Program
    {
        /*
         Yoda is starting his newly created Jedi academy. So, he asked master John to buy the needed equipment. The number of items depends on how many students will sign up. The equipment for each Padawan contains:

            · Lightsaber

            · Belt

            · Robe

            You will be given the amount of money John has, the number of students and the prices of each item. Calculate if John has enough money to buy equipment for each Padawan or how much more money he needs.

            There are some additional requirements:

            · Lightsabres sometimes break, so John should buy 10% more (taken from the students' count), rounded up to the next integer.

            · Every sixth belt is free.
         
         */
        static void Main(string[] args)
        {
            double amountOfMoneyJohnHas = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());

            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double lightsabersPriceAfterAddedPercent = Math.Ceiling(numberOfStudents * 1.1) * priceOfLightsaber;
            double priceOfAllRobes = numberOfStudents * priceOfRobe;
            int freeBelts = numberOfStudents / 6;
            
            double priceForAllBelts = (numberOfStudents - freeBelts) * priceOfBelt;

            double sum = lightsabersPriceAfterAddedPercent + priceOfAllRobes + priceForAllBelts;

            if (sum <= amountOfMoneyJohnHas)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                double neededMoney = sum - amountOfMoneyJohnHas;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
