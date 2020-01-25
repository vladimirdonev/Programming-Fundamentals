using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            int counter = 1;
            var resources = new Dictionary<string, int>();
            string oldkey = null;
            while (command != "stop")
            {
                command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                if (counter % 2 == 0)
                {
                    int number = int.Parse(command);
                    if (resources.ContainsKey(oldkey))
                    {
                        resources[oldkey] += number;
                    }
                }
                else
                {
                    if (!resources.ContainsKey(command))
                    {
                        resources[command] = 0;
                    }
                    oldkey = command;
                }

                counter++;
            }
            foreach (var resource in resources)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}