using System;
using System.Collections.Generic;
using System.Linq;

namespace Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            var meals = new Dictionary<string, List<string>>();
            string command = null;
            int unlikedmeals = 0;
            List<string> moremeals = new List<string>();
            while (command != "Stop")
            {
                command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }
                string[] splitedinput = command.Split('-');
                string currentcommand = splitedinput[0];
                if (currentcommand == "Like")
                {
                    string Guest = splitedinput[1];
                    string meal = splitedinput[2];
                    moremeals.Add(meal);
                    if (!meals.ContainsKey(Guest))
                    {
                        meals.Add(Guest, moremeals);
                    }
                    else
                    {
                        if (!meals[Guest].Contains(meal))
                        {
                            meals[Guest].Add(meal);
                        }
                    }
                    moremeals = new List<string>();
                }
                else if (currentcommand == "Unlike")
                {
                    string Guest = splitedinput[1];
                    string meal = splitedinput[2];
                    if (!meals.ContainsKey(Guest))
                    {
                        Console.WriteLine($"{Guest} is not at the party.");
                    }
                    else
                    {
                        if (!meals[Guest].Contains(meal))
                        {
                            Console.WriteLine($"{Guest} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            meals[Guest].Remove(meal);
                            unlikedmeals++;
                            Console.WriteLine($"{Guest} doesn't like the {meal}.");
                        }
                    }
                }
            }
            foreach (var item in meals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedmeals}");
        }
    }
}
