using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var regex = new Regex(@"(?<firstsumbol>!)(?<command>[A-Z]+[a-z]{3,})(?<secondsumbol>!):\[(?<message>[A-z]{8,})\]$");
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                if (regex.IsMatch(message))
                {
                    Match match = regex.Match(message);
                    var firstsumbol = match.Groups["firstsumbol"].Value;
                    var command = match.Groups["command"].Value;
                    var secondsumbol = match.Groups["secondsumbol"].Value;
                    var decriptedmessage = match.Groups["message"].Value;
                    if (firstsumbol == secondsumbol)
                    {
                        for (int j = 0; j < decriptedmessage.Length; j++)
                        {
                            string letter = decriptedmessage[j].ToString();
                            char one = letter[0];
                            numbers.Add(one);
                        }
                        Console.WriteLine($"{command}: {string.Join(" ", numbers)}");
                    }
                    else
                    {
                        Console.WriteLine("The message is invalid");
                    }
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
