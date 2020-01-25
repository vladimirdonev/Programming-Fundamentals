using System;
using System.Linq;
using System.Collections.Generic;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givennumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstnumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextnumber = numbers[j];
                    int sum = firstnumber + nextnumber;
                    if (sum == givennumber)
                    {
                        Console.Write(firstnumber + " ");
                        Console.WriteLine(nextnumber + " ");
                    }
                }
            }
        }
    }
}
