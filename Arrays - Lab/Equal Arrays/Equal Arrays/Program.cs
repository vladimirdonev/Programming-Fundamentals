using System;
using System.Linq;
using System.Collections.Generic;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int sum1 = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index ");
                    return;
                }
                if (first[i] == second[i])
                {


                    sum += first[i];
                    sum1 += second[i];
                }


            }
            if (sum == sum1)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
