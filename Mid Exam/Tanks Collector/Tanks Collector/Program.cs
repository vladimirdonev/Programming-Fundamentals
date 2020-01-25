using System;
using System.Collections.Generic;
using System.Linq;

namespace Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Tanks = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            byte numberofcommands = byte.Parse(Console.ReadLine());
            string command = string.Empty;
            for (int i = 1; i <= numberofcommands; i++)
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string currentcommand = splitedinput[0];
                if (currentcommand == "Add")
                {
                    string tankname = splitedinput[1];
                    if (Tanks.Contains(tankname))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        Tanks.Add(tankname);
                        Console.WriteLine("Tank successfully bought");
                    }
                }
                else if (currentcommand == "Remove")
                {
                    string tankname = splitedinput[1];
                    if (Tanks.Contains(tankname))
                    {
                        Tanks.Remove(tankname);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (currentcommand == "Remove At")
                {
                    int index = int.Parse(splitedinput[1]);
                    if (index >= 0 && index < Tanks.Count)
                    {
                        Tanks.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (currentcommand == "Insert")
                {
                    int index = int.Parse(splitedinput[1]);
                    string tankname = splitedinput[2];
                    if (index >= 0 && index < Tanks.Count)
                    {
                        if (Tanks.Contains(tankname))
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                        else
                        {
                            Tanks.Insert(index, tankname);
                            Console.WriteLine("Tank successfully bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", Tanks));
        }
    }
}