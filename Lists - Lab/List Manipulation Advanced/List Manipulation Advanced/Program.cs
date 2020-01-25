using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numberscopy = numbers;
            string command = string.Empty;
            int count = 0;
            while (command != "end")
            {
                command = Console.ReadLine();
                string[] tokens = command.Split();
                if (tokens[0] == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (tokens[0] == "PrintEven")
                {
                    List<int> even = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            int number = numbers[i];
                            even.Add(number);
                        }
                    }
                    Console.WriteLine(string.Join(" ", even));
                }
                if (tokens[0] == "PrintOdd")
                {
                    List<int> odd = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            int number = numbers[i];
                            odd.Add(number);
                        }
                    }
                    Console.WriteLine(string.Join(" ", odd));
                }
                if (tokens[0] == "GetSum")
                {
                    numbers.Sum();
                    Console.WriteLine(numbers.Sum());
                }

                else if (tokens[0] == "Filter")
                {
                    string symbol = tokens[1];
                    int filter = int.Parse(tokens[2]);
                    if (symbol == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < filter)));
                    }
                    else if (symbol == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > filter)));
                    }
                    else if (symbol == ">=")
                    {
                        // result = numbersMore.Where(x => x >= filter).ToList();
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= filter)));
                    }
                    else if (symbol == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= filter)));
                    }
                }
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
                if (tokens[0] == "Add" || tokens[0] == "Remove" || tokens[0] == "RemoveAt" || tokens[0] == "Insert")
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
