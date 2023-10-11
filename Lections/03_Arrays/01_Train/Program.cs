using System;
using System.Linq;

namespace _01_Train
{
    internal class Program
    {
        /*
         A train has n number of wagons (integer, received as input). On the next n lines, you will receive the number of people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the total number of passengers on the train.
         
         */
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());

            int[] passengersPerWagon = new int[wagonCount];

            for (int i = 0; i < wagonCount; i++)
            {
                passengersPerWagon[i] = int.Parse(Console.ReadLine());
            }

            //int totalPassengers = passengersPerWagon.Sum(); can use this instead of the for loop

            //loop to calculate the som of the passengers
            int totalPassengers = 0; 

            for (int i = 0; i < wagonCount; i++)
            {
                totalPassengers += passengersPerWagon[i];
            }


            Console.WriteLine(string.Join(" ", passengersPerWagon));
            Console.WriteLine(totalPassengers);

        }
    }
}
