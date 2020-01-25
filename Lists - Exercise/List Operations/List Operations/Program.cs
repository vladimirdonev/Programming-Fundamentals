using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = string.Empty;
            while (command != "End")
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(' ');
                if (command == "End")
                {
                    break;
                }
                if (splitedinput[0] == "Add")
                {
                    int number = int.Parse(splitedinput[1]);
                    numbers.Add(number);
                }
                if (splitedinput[0] == "Insert")
                {
                    int index = int.Parse(splitedinput[2]);
                    int number = int.Parse(splitedinput[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                if (splitedinput[0] == "Remove")
                {
                    int number = int.Parse(splitedinput[1]);
                    if (number < 0 || number > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        numbers.RemoveAt(number);
                    }

                }
                if (splitedinput[1] == "left")
                {
                    int count = int.Parse(splitedinput[2]);
                    for (int i = 0; i < count % numbers.Count; i++)
                    {
                        int firstNum = numbers[0];
                        numbers.Add(firstNum);
                        numbers.RemoveAt(0);
                    }
                }
                if (splitedinput[1] == "right")
                {
                    int count = int.Parse(splitedinput[2]);
                    for (int i = 0; i < count % numbers.Count; i++)
                    {
                        int lastNum = numbers[numbers.Count - 1];
                        numbers.Insert(0, lastNum);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
