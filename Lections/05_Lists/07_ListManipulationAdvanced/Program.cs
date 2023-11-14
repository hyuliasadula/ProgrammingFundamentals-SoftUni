using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ListManipulationAdvanced
{
    internal class Program
    {
        /*
         Next, we are going to implement more complicated list commands, extending the previous task. Again, read a list and keep reading commands until you receive "end":
        • Contains {number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
        • PrintEven – print all the even numbers, separated by a space.
        • PrintOdd – print all the odd numbers, separated by a space.
        • GetSum – print the sum of all the numbers.
        • Filter {condition} {number} – print all the numbers that fulfill the given condition. The condition will be either '<', '>', ">=", "<=".
        After the end command, print the list only if you have made some changes to the original list. Changes are made only from the commands from the previous task
         
         */
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool changesMade = false;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] actionArgs = command.Split();
                string action = actionArgs[0];

                if (IsBasicCommand(action))
                {
                    ProcessCommands(action, actionArgs, listOfNumbers);
                    changesMade = true; // Set changesMade to true for any basic command
                }
                else
                {
                    ComplicatedCommands(listOfNumbers, actionArgs, action);
                }
            }

            if (changesMade)
            {
                Console.WriteLine(string.Join(" ", listOfNumbers));
            }
        }

        static bool IsBasicCommand(string action)
        {
            string[] basicCommands = { "Add", "Remove", "RemoveAt", "Insert" };
            return basicCommands.Contains(action);
        }

        static void ProcessCommands(string action, string[] actionArgs, List<int> numbers)
        {
            int number, index;

            switch (action)
            {
                case "Add":
                    number = int.Parse(actionArgs[1]);
                    numbers.Add(number);
                    break;

                case "Remove":
                    number = int.Parse(actionArgs[1]);
                    numbers.Remove(number);
                    break;

                case "RemoveAt":
                    index = int.Parse(actionArgs[1]);
                    numbers.RemoveAt(index);
                    break;

                case "Insert":
                    number = int.Parse(actionArgs[1]);
                    index = int.Parse(actionArgs[2]);
                    numbers.Insert(index, number);
                    break;
            }
        }

        private static void ComplicatedCommands(List<int> listOfNumbers, string[] actionArgs, string action)
        {
            int number;

            switch (action)
            {
                case "Contains":
                    number = int.Parse(actionArgs[1]);
                    Console.WriteLine(listOfNumbers.Contains(number) ? "Yes" : "No such number");
                    break;

                case "PrintEven":
                    List<int> evenNumbers = listOfNumbers.Where(IsEven).ToList();
                    Console.WriteLine(string.Join(" ", evenNumbers));
                    break;

                case "PrintOdd":
                    List<int> oddNumbers = listOfNumbers.Where(IsOdd).ToList();
                    Console.WriteLine(string.Join(" ", oddNumbers));
                    break;

                case "GetSum":
                    int sum = listOfNumbers.Sum();
                    Console.WriteLine(sum);
                    break;

                case "Filter":
                    string condition = actionArgs[1];
                    int filterNumber = int.Parse(actionArgs[2]);

                    List<int> filteredNumbers = FilterNumbers(listOfNumbers, condition, filterNumber);
                    Console.WriteLine(string.Join(" ", filteredNumbers));
                    break;
            }
        }

        private static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        private static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }

        private static List<int> FilterNumbers(List<int> numbers, string condition, int filterNumber)
        {
            switch (condition)
            {
                case "<":
                    return numbers.Where(num => num < filterNumber).ToList();

                case ">":
                    return numbers.Where(num => num > filterNumber).ToList();

                case "<=":
                    return numbers.Where(num => num <= filterNumber).ToList();

                default: //">="
                    return numbers.Where(num => num >= filterNumber).ToList();
            }
        }
    }
}
