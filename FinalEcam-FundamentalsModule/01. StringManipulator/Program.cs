using System;

namespace _01._StringManipulator
{
    internal class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "End")
            {
                inputString = HandleCommands(inputString, command);

                command = Console.ReadLine();
            }
        }

        static string HandleCommands(string inputString, string command)
        {
            string[] arguments = command.Split();

            switch (arguments[0])
            {
                case "Translate":
                    return Translate(inputString, arguments);

                case "Includes":
                    return Includes(inputString, arguments);

                case "Start":
                    return Start(inputString, arguments);

                case "Lowercase":
                    return Lowercase(inputString);

                case "FindIndex":
                    return FindIndex(inputString, arguments);

                case "Remove":
                    return Remove(inputString, arguments);

                default:
                    return inputString;
            }
        }

        static string Translate(string inputString, string[] arguments)
        {
            char charToReplace = char.Parse(arguments[1]);
            string replacement = arguments[2];
            inputString = inputString.Replace(charToReplace, replacement[0]);
            Console.WriteLine(inputString);
            return inputString;
        }

        static string Includes(string inputString, string[] arguments)
        {
            string substringInclude = arguments[1];
            Console.WriteLine(inputString.Contains(substringInclude));
            return inputString;
        }

        static string Start(string inputString, string[] arguments)
        {
            string substringStart = arguments[1];
            Console.WriteLine(inputString.StartsWith(substringStart));
            return inputString;
        }

        static string Lowercase(string inputString)
        {
            inputString = inputString.ToLower();
            Console.WriteLine(inputString);
            return inputString;
        }

        static string FindIndex(string inputString, string[] arguments)
        {
            char findChars = char.Parse(arguments[1]);
            int lastIndex = inputString.LastIndexOf(findChars);
            Console.WriteLine(lastIndex);
            return inputString;
        }

        static string Remove(string inputString, string[] arguments)
        {
            int startIndex = int.Parse(arguments[1]);
            int countToRemove = int.Parse(arguments[2]);
            inputString = inputString.Remove(startIndex, countToRemove);
            Console.WriteLine(inputString);
            return inputString;
        }
    }
}