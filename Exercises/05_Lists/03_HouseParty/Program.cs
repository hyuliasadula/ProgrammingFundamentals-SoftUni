using System;
using System.Collections.Generic;

namespace _03_HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                UpdateGuestList(command, guests);
            }

            PrintGuests(guests);
        }

        static void UpdateGuestList(string command, List<string> guests)
        {
            string[] tokens = command.Split();

            string name = tokens[0];

            if (tokens[2] == "going!")
            {
                if (guests.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    guests.Add(name);
                }
            }
            else if (tokens[2] == "not")
            {
                if (guests.Contains(name))
                {
                    guests.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }

        static void PrintGuests(List<string> guests)
        {
            // Print each guest on a new line
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
