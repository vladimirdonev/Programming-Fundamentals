using System;

namespace Password_Validator
{
    class Program
    {
        public static void Main()
        {
            string password = Console.ReadLine();

            bool isBetween6and10 = CheckLengthOfPassword(password);
            if (isBetween6and10 == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool containsOnlyDigitsAndLetters = ContainsOnlyDigitsAndLetters(password);
            if (containsOnlyDigitsAndLetters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool containsMinimum2Digits = CheckMinDigit(password);
            if (containsMinimum2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isBetween6and10 && containsOnlyDigitsAndLetters && containsMinimum2Digits)
            {
                Console.WriteLine("Password is valid");
            }

        }
        private static bool CheckMinDigit(string password)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    count++;
                }

            }
            return count >= 2 ? true : false;

        }
        private static bool ContainsOnlyDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool CheckLengthOfPassword(string password)
        {
            return password.Length >= 6 && password.Length <= 10 ? true : false;
        }

    }
}
