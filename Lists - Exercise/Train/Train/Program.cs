using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            int capacite = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitedinput = input.Split(' ');
                if (splitedinput.Length == 1)
                {
                    int passengers = int.Parse(splitedinput[0]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i] + passengers <= capacite)
                        {
                            wagon[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                    int passengrs = int.Parse(splitedinput[1]);
                    wagon.Add(passengrs);
                }
            }
            Console.WriteLine(string.Join(" ", wagon));

        }
    }
}
