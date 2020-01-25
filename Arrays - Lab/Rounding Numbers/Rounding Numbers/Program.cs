using System;
using System.Collections.Generic;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                double number = nums[i];
                double roundedNums = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNums}");
            }
        }
    }
}
