using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfCards = Console.ReadLine()
                                                .Split(", ")
                                                .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(", ");
                string action = command[0];
                string cardName = command[1];

                ExecuteCommand(listOfCards, action, cardName, command);
            }

            Console.WriteLine(string.Join(", ", listOfCards));
        }

        static void ExecuteCommand(List<string> listOfCards, string action, string cardName, string[] command)
        {
            if (action == "Add")
            {
                PerformAddAction(listOfCards, cardName);
            }
            else if (action == "Remove")
            {
                PerformRemoveAction(listOfCards, cardName);
            }
            else if (action == "Remove At")
            {
                PerformRemoveAtAction(listOfCards, cardName);
            }
            else if (action == "Insert")
            {
                string nameOfCard = string.Join(", ", command.Skip(2));
                PerformInsertAction(listOfCards, cardName, nameOfCard);
            }

            static void PerformAddAction(List<string> listOfCards, string cardName)
            {
                if (listOfCards.Contains(cardName))
                {
                    Console.WriteLine("Card is already in the deck");
                }
                else
                {
                    listOfCards.Add(cardName);
                    Console.WriteLine("Card successfully added");
                }
            }

            static void PerformRemoveAction(List<string> listOfCards, string cardName)
            {
                if (listOfCards.Contains(cardName))
                {
                    listOfCards.Remove(cardName);
                    Console.WriteLine("Card successfully removed");
                }
                else
                {
                    Console.WriteLine("Card not found");
                }
            }

            static void PerformRemoveAtAction(List<string> listOfCards, string cardName)
            {
                int index = int.Parse(cardName);
                if (index >= 0 && index < listOfCards.Count)
                {
                    listOfCards.RemoveAt(index);
                    Console.WriteLine("Card successfully removed");
                }
                else
                {
                    Console.WriteLine("Index out of range");
                }
            }

            static void PerformInsertAction(List<string> listOfCards, string indexStr, string fullCardName)
            {
                int insertIndex = int.Parse(indexStr);

                // Check if the insertIndex is within a valid range
                if (insertIndex >= 0 && insertIndex < listOfCards.Count)
                {
                    // Check if the card is not already in the deck
                    if (!listOfCards.Contains(fullCardName))
                    {
                        // Insert the card at the specified index
                        listOfCards.Insert(insertIndex, fullCardName);
                        Console.WriteLine("Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine("Card is already added");
                    }
                }
                else
                {
                    Console.WriteLine("Index out of range");
                }
            }


        }
    }
}
