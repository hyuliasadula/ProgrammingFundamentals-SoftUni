using System;
using System.Text.RegularExpressions;

namespace _02._BossRush
{
    internal class BossInfoValidator
    {
        static void Main()
        {
            int numberOfInputs = GetNumberOfInputs();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = GetBossInput();
                ValidateAndPrintBossInfo(input);
            }
        }

        static int GetNumberOfInputs()
        {
            int numberOfInputs;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numberOfInputs) && numberOfInputs > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }

            return numberOfInputs;
        }

        static string GetBossInput()
        {
            return Console.ReadLine();
        }

        static void ValidateAndPrintBossInfo(string input)
        {
            string pattern = @"\|([A-Z]{4,})\|:#([A-Za-z]+ [A-Za-z]+)#";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            if (match.Success)
            {
                string bossName = match.Groups[1].Value;
                string title = match.Groups[2].Value;

                PrintBossInfo(bossName, title);
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        static void PrintBossInfo(string bossName, string title)
        {
            Console.WriteLine($"{bossName}, The {title}");
            Console.WriteLine($">> Strength: {bossName.Length}");
            Console.WriteLine($">> Armor: {title.Length}");
        }
    }
}
