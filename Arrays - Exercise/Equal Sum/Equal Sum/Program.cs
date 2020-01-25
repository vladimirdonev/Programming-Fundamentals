using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstnumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int sum2 = firstnumbers.Sum();
            for(int i = 0; i < firstnumbers.Length; i++)
            {
                sum2 -= firstnumbers[i];

                if(sum == sum2)
                {
                    Console.WriteLine(i);
                    return;
                }
                sum += firstnumbers[i];
            }
            Console.WriteLine("no");
        }
    }
}
