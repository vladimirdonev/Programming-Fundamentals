using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {

            var patternName = new Regex(@"(?<name>[A-Za-z]+)");
            string patternDigits = @"(?<digits>\d+)";

            int sumOfDigits = 0;

            Dictionary<string, int> participants = new Dictionary<string, int>();

            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                var matchedNames = patternName.Matches(input);
                var matchedDigits = Regex.Matches(input, patternDigits);

                string currentName = string.Join("", matchedNames);
                string currentDigit = string.Join("", matchedDigits);

                sumOfDigits = 0;

                for (int i = 0; i < currentDigit.Length; i++)
                {
                    sumOfDigits += int.Parse(currentDigit[i].ToString());
                }

                if (names.Contains(currentName))
                {

                    if (!participants.ContainsKey(currentName))
                    {
                        participants.Add(currentName, sumOfDigits);
                    }

                    else
                    {
                        participants[currentName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            var currentWinners = participants
               .OrderByDescending(x => x.Value)
               .Take(3);

            var firstWinner = currentWinners
                .Take(1);

            var secondWinner = currentWinners
                .OrderByDescending(x => x.Value)
                .Take(2)
                .OrderBy(x => x.Value)
                .Take(1);

            var thirdWinner = currentWinners
                .OrderBy(x => x.Value)
                .Take(1);

            foreach (var firstName in firstWinner)
            {
                Console.WriteLine($"1st place: {firstName.Key}");

            }

            foreach (var secondName in secondWinner)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }

            foreach (var thirdName in thirdWinner)
            {
                Console.WriteLine($"3rd place: {thirdName.Key}");
            }
        }
    }
}
