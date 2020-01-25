using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while (command != "end")
            {
                command = Console.ReadLine();
                string[] tokens = command.Split();
                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                if (tokens[0] == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Remove(number);
                }
                if (tokens[0] == "RemoveAt")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.RemoveAt(number);
                }
                if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
}
