using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ListManipulationBasics
{
    internal class Program
    {
        /*
         Create a program that reads a list of integers. Then until you receive "end", you will receive different commands:
        • Add {number}: add a number to the end of the list.
        • Remove {number}: remove a number from the list.
        • RemoveAt {index}: remove a number at a given index.
        • Insert {number} {index}: insert a number at a given index.
        Note: All the indices will be valid!
        When you receive the "end" command, print the final state of the list (separated by spaces).


        Input                   Output
        4 19 2 53 6 43           4 53 6 8 43 3
        Add 3
        Remove 2
        RemoveAt 1
        Insert 8 3
        end
                               
         
         */
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] actionArgs = command.Split();
                string action = actionArgs[0];

                ProcessCommands(action, actionArgs, listOfNumbers);
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }

        static void ProcessCommands(string action, string[] actionArgs, List<int> numbers)
        {
            int number, index;

            if (action == "Add")
            {
                number = int.Parse(actionArgs[1]);
                numbers.Add(number);
            }
            else if (action == "Remove")
            {
                number = int.Parse(actionArgs[1]);
                numbers.Remove(number);
            }
            else if (action == "RemoveAt")
            {
                index = int.Parse(actionArgs[1]);
                numbers.RemoveAt(index);
            }
            else //if (action == "Insert")
            {
                number = int.Parse(actionArgs[1]);
                index = int.Parse(actionArgs[2]);
                numbers.Insert(index, number);
            }
           
        }
    }
}