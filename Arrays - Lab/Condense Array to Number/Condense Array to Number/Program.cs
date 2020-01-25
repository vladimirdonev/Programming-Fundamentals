using System;
using System.Linq;
using System.Collections.Generic;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondnumber = new int[numbers.Length - 1];
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < secondnumber.Length - i; j++)
                {
                    secondnumber[j] = numbers[j] + numbers[j + 1];
                }
                numbers = secondnumber;
            }
            Console.WriteLine(secondnumber[0]);
        }
    }
}
