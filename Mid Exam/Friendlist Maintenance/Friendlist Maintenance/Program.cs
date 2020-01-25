using System;
using System.Collections.Generic;
using System.Linq;

namespace Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Friends = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            int Blacklistednamescount = 0;
            int lostnamescount = 0;
            while (command != "Report")
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(' ');
                string currentcommand = splitedinput[0];
                if (currentcommand == "Blacklist")
                {
                    string name = splitedinput[1];
                    if (Friends.Contains(name))
                    {
                        int index = Friends.FindIndex(x => x == name);
                        Friends.RemoveAt(index);
                        Friends.Insert(index, "Blacklisted");
                        Console.WriteLine($"{name} was blacklisted.");
                        Blacklistednamescount++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (currentcommand == "Error")
                {
                    int index = int.Parse(splitedinput[1]);
                    for (int i = 0; i < Friends.Count; i++)
                    {
                        string lostname = Friends[i];
                        if (i == index)
                        {
                            if (Friends[i] == "Blacklisted" || Friends[i] == "Lost")
                            {

                            }
                            else
                            {
                                Friends[i] = "Lost";
                                Console.WriteLine($"{lostname} was lost due to an error.");
                                lostnamescount++;
                            }
                        }
                    }

                }
                else if (currentcommand == "Change")
                {
                    int index = int.Parse(splitedinput[1]);
                    string newname = splitedinput[2];
                    string oldname = null;
                    if (index >= 0 && index < Friends.Count)
                    {
                        for (int i = 0; i < Friends.Count; i++)
                        {
                            if (i == index)
                            {
                                oldname = Friends[i];
                                Friends[i] = newname;
                            }
                        }
                        Console.WriteLine($"{oldname} changed his username to {newname}.");
                    }
                }
                else if (currentcommand == "Report")
                {
                    Console.WriteLine($"Blacklisted names: {Blacklistednamescount}");
                    Console.WriteLine($"Lost names: {lostnamescount}");
                    Console.WriteLine(string.Join(" ", Friends));
                    break;
                }
            }
        }
    }
}
