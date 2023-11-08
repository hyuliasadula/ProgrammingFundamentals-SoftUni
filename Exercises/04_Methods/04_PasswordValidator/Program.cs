using System;

namespace _04_PasswordValidator
{
    internal class Program
    {
        /*
         Create a program that checks if a given password is valid.
        The password validation rules are:
        • It should contain 6 – 10 characters (inclusive)
        • It should contain only letters and digits
        • It should contain at least 2 digits

        If it is not valid, for any unfulfilled rule print the corresponding message:
        • "Password must be between 6 and 10 characters"
        • "Password must consist only of letters and digits"
        • "Password must have at least 2 digits"
        */

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidationChecker(password);

        }

        private static void ValidationChecker(string password)
        {
            bool isValid = true;

            if (!CheckCountOfCharacters(password))
            {
                isValid = false;
            }

            if (!CountLettersAndNumbers(password))
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckCountOfCharacters(string password)
        {
            // Count the characters in the password
            int charCounter = password.Length;

            // 6 – 10 characters
            if (charCounter < 6 || charCounter > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }

            return true;
        }

        private static bool CountLettersAndNumbers(string password)
        {
            char[] charArray = password.ToCharArray();

            int letterCount = 0;
            int numberCount = 0;
            int symbolCount = 0;
            bool containsSymbol = false;

            foreach (char character in charArray)
            {
                if (char.IsLetter(character))
                {
                    letterCount++;
                }
                else if (char.IsDigit(character))
                {
                    numberCount++;
                }
                else
                {
                    symbolCount++;
                    containsSymbol = true;
                }
            }
            if (containsSymbol)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (numberCount < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }

            return true;
        }
    }
}
