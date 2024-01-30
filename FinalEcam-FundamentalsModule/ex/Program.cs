using System;

class Program
{
    static void Main()
    {
        // Read the concealed message
        string concealedMessage = Console.ReadLine();

        // Process commands until "Reveal" is received
        string command;
        while ((command = Console.ReadLine()) != "Reveal")
        {
            string[] commandParts = command.Split(":|:");

            switch (commandParts[0])
            {
                case "InsertSpace":
                    int indexToInsert = int.Parse(commandParts[1]);
                    concealedMessage = InsertSpace(concealedMessage, indexToInsert);
                    break;

                case "Reverse":
                    string substringToReverse = commandParts[1];
                    concealedMessage = ReverseSubstring(concealedMessage, substringToReverse);
                    break;

                case "ChangeAll":
                    string substringToReplace = commandParts[1];
                    string replacement = commandParts[2];
                    concealedMessage = ChangeAll(concealedMessage, substringToReplace, replacement);
                    break;
            }

            // Print the resulting string after each set of instructions
            Console.WriteLine(concealedMessage);
        }

        // Print the final revealed message
        Console.WriteLine($"You have a new text message: {concealedMessage}");
    }

    static string InsertSpace(string message, int index)
    {
        // Insert a space at the given index
        return message.Insert(index, " ");
    }

    static string ReverseSubstring(string message, string substring)
    {
        // Find the first occurrence of the substring
        int index = message.IndexOf(substring);

        if (index != -1)
        {
            // Cut out the substring, reverse it, and add it at the end of the message
            string reversedSubstring = new string(substring.ToCharArray().Reverse().ToArray());
            message = message.Remove(index, substring.Length) + reversedSubstring;
        }
        else
        {
            // Print "error" if the substring is not found
            Console.WriteLine("error");
        }

        return message;
    }

    static string ChangeAll(string message, string substring, string replacement)
    {
        // Replace all occurrences of the substring with the replacement text
        return message.Replace(substring, replacement);
    }
}
