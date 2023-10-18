using System;

namespace _09_GreaterOfTwoValues
{
    internal class Program
    {
        /*
         You are given an input of two values of the same type. The values can be of type int, char or string. Create
methods called GetMax(), which can compare int, char or string and returns the biggest of the two values.


        Input   Output
        int
        2
        16
                  16


        char
        a
        z
                     z
        string
        aaa
        bbb

                    bbb

         
         
         */
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            string maxValue = GetMax(type, firstValue, secondValue);

            Console.WriteLine(maxValue);
        }

        private static string GetMax(string type, string firstValue, string secondValue)
        {
            if (type == "string")
            {
                return GetMaxString(firstValue, secondValue);
            }
            else if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(secondValue);
                return GetMaxInt(firstInt, secondInt).ToString();
            }
            else // char
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                return GetMaxChar(firstChar, secondChar).ToString();
            }
        }

        private static string GetMaxString(string firstValue, string secondValue)
        {
            return (string.Compare(firstValue, secondValue) > 0) ? firstValue : secondValue;
        }

        private static int GetMaxInt(int firstValue, int secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }

        private static char GetMaxChar(char firstValue, char secondValue)
        {
            return (firstValue > secondValue) ? firstValue : secondValue;
        }
    }
}
