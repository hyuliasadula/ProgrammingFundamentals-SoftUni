using System;

namespace _01_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBiscuits = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int numberOfBiscuitsProducedFor30Days = int.Parse(Console.ReadLine());
            int productionPerMonth = 0;

            int firstDay = 1;
            int lastDay = 30;
            for (int day = firstDay; day <= lastDay; day++)
            {

                int productionPerDay = numberOfBiscuits * countOfWorkers;
                if (day % 3 != 0) 
                {
                    productionPerMonth += productionPerDay;

                }
                else
                {
                    productionPerMonth += (int)(productionPerDay * 0.75);
                }
                
            }
            

            double percentageDifference = ((double)productionPerMonth - numberOfBiscuitsProducedFor30Days) / numberOfBiscuitsProducedFor30Days * 100;

            if (percentageDifference > 0)
            {
                Console.WriteLine($"You have produced {productionPerMonth} biscuits for the past month.");
                Console.WriteLine($"You produce {percentageDifference:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You have produced {productionPerMonth} biscuits for the past month.");
                Console.WriteLine($"You produce {Math.Abs(percentageDifference):F2} percent less biscuits.");
            }
        }
    }
}
