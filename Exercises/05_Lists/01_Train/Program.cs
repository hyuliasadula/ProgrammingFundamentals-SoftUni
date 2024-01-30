using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput == "end")
                {
                    break;
                }

                string[] userCommandArgs = userInput.Split();
                string userAction = userCommandArgs[0];

                ProcessUserCommand(userAction, userCommandArgs, trainWagons, maxWagonCapacity);
            }

            Console.WriteLine(string.Join(" ", trainWagons));
        }

        static void ProcessUserCommand(string action, string[] commandArgs, List<int> wagons, int maxCapacity)
        {
            int passengers;

            if (action == "Add")
            {
                passengers = int.Parse(commandArgs[1]);
                wagons.Add(passengers);
            }
            else
            {
                passengers = int.Parse(commandArgs[0]);

                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + passengers <= maxCapacity)
                    {
                        wagons[i] += passengers;
                        break;
                    }
                }
            }
        }
    }
}
