using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int oddsum = 0;
            int evensum = 0;
            for (int i = 0; i < firs.Length; i++)
            {
                int current = firs[i];
                if (current % 2 == 0)
                {
                    evensum += current;
                }
                else
                {
                    oddsum += current;
                }
            }
            Console.WriteLine(evensum - oddsum);
        }
    }
}
