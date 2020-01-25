using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main()
    {
        var exam = new Dictionary<string, int>();
        var submission = new Dictionary<string, int>();
        string command = null;
        while (command != "exam finished")
        {
            command = Console.ReadLine();
            if (command == "exam finished")
            {
                break;
            }
            string[] splitedinput = command.Split('-');
            string username = splitedinput[0];
            string language = splitedinput[1];
            if (language == "banned")
            {
                exam.Remove(username);
            }
            else
            {
                int points = int.Parse(splitedinput[2]);
                if (!submission.ContainsKey(language))
                {
                    submission.Add(language, 1);
                    if (!exam.ContainsKey(username))
                    {
                        exam.Add(username, points);
                    }
                }
                else
                {
                    if (exam.ContainsKey(username))
                    {
                        exam[username] = points;
                        submission[language]++;
                    }
                    else
                    {
                        submission[language]++;
                        exam.Add(username, points);
                    }
                }
            }
        }
        Console.WriteLine("Results:");
        foreach (var item in exam.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0} | {1}", item.Key, item.Value);
        }
        Console.WriteLine("Submissions:");
        foreach (var item in submission.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }
}