using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        public static void Main()
        {
            string command = null;
            var parkinglot = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(' ');
                string currentcommand = splitedinput[0];
                string user = splitedinput[1];
                if (currentcommand == "register")
                {
                    string licensePlateNumber = splitedinput[2];
                    if (parkinglot.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        parkinglot.Add(user, licensePlateNumber);
                        Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
                    }
                }
                else if (currentcommand == "unregister")
                {
                    if (parkinglot.ContainsKey(user))
                    {
                        parkinglot.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }
            foreach (var item in parkinglot)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
