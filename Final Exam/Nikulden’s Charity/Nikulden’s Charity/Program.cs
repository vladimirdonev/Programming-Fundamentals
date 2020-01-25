using System;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string command = null;
            while (command != "Finish")
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(' ');
                string currentcommand = splitedinput[0];
                if (currentcommand == "Replace")
                {
                    string old = splitedinput[1];
                    string newone = splitedinput[2];
                    word = word.Replace(old, newone);
                    Console.WriteLine(word);
                }
                else if (currentcommand == "Cut")
                {
                    int start = int.Parse(splitedinput[1]);
                    int end = int.Parse(splitedinput[2]);
                    int min = Math.Min(start, end);
                    int max = Math.Max(start, end);
                    string cut = null;
                    if (min >= 0 && max < word.Length)
                    {
                        cut = word.Remove(min, max);
                        Console.WriteLine(cut);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (currentcommand == "Make")
                {
                    string upperlower = splitedinput[1];
                    if (upperlower == "Upper")
                    {
                        word = word.ToUpper();
                        Console.WriteLine(word);
                    }
                    else if (upperlower == "Lower")
                    {
                        word = word.ToLower();
                        Console.WriteLine(word);
                    }
                }
                else if (currentcommand == "Check")
                {
                    string have = splitedinput[1];
                    if (word.Contains(have))
                    {
                        Console.WriteLine($"Message contains {have}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {have}");
                    }
                }
                else if (currentcommand == "Sum")
                {
                    int start = int.Parse(splitedinput[1]);
                    int end = int.Parse(splitedinput[2]);
                    int min = Math.Min(start, end);
                    int max = Math.Max(start, end);
                    int sum = 0;
                    if (min >= 0 && max < word.Length)
                    {
                        string needtosum = word.Substring(min, max);
                        for (int i = 0; i < needtosum.Length; i++)
                        {
                            string first = needtosum[i].ToString();
                            char tochar = first[0];
                            sum += tochar;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
            }
        }
    }
}
