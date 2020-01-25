using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitedinput = input.Split(' ');
                string command = splitedinput[0];
                int number = int.Parse(splitedinput[1]);
                if (command == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (number == numbers[i])
                        {
                            numbers.Remove(number);
                            i--;
                        }
                    }
                }
                else if (command == "Insert")
                {
                    int position = int.Parse(splitedinput[2]);
                    numbers.Insert(position, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
