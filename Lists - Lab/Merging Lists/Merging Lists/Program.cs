using System;
using System.Linq;
using System.Collections.Generic;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondnumber = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            if (number.Count >= secondnumber.Count)
            {
                for (int i = 0; i < number.Count; i++)
                {
                    result.Add(number[i]);
                    if (i < secondnumber.Count)
                    {
                        result.Add(secondnumber[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondnumber.Count; i++)
                {
                    if (i < number.Count)
                    {
                        result.Add(number[i]);
                    }
                    result.Add(secondnumber[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
