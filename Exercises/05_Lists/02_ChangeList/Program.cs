using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
    internal class Program
    {
        /*
         Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
            Your program may receive the following commands:
            • Delete {element} – delete all elements in the array, which are equal to the given element.
            • Insert {element} {position} – insert the element at the given position.
            You should exit the program when you receive the "end" command. Print all numbers in the array, separated by a single whitespace

        Input                           Output
        1 2 3 4 5 5 5 6                 1 10 2 3 4 6
        Delete 5
        Insert 10 1
        Delete 5
        end


         
         */
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                ProcessCommand(command, numbers);
            }

            PrintNumbers(numbers);
        }

        static void ProcessCommand(string command, List<int> numbers)
        {
            string[] tokens = command.Split();
            string action = tokens[0];

            if (action == "Delete")
            {
                int elementToDelete = int.Parse(tokens[1]);
                DeleteElement(numbers, elementToDelete);
            }
            else if (action == "Insert")
            {
                int elementToInsert = int.Parse(tokens[1]);
                int position = int.Parse(tokens[2]);
                InsertElement(numbers, elementToInsert, position);
            }
        }

        static void DeleteElement(List<int> numbers, int elementToDelete)
        {
            numbers.RemoveAll(num => num == elementToDelete);
        }

        static void InsertElement(List<int> numbers, int elementToInsert, int position)
        {
            numbers.Insert(position, elementToInsert);
        }

        static void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}