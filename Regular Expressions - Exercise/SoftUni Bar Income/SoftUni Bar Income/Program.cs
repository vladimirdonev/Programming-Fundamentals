using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double totalIncome = 0;
            while (command != "end of shift")
            {
                command = Console.ReadLine();
                if (command == "end of shift")
                {
                    break;
                }
                if (Regex.IsMatch(command, pattern))
                {
                    Match match = Regex.Match(command, pattern);
                    var customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * count;
                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    totalIncome += money;
                }

            }
            Console.WriteLine($"Total income: {totalIncome:F2}");


        }
    }
}
