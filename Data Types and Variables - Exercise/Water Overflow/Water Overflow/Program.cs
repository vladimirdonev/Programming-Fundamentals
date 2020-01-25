using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int liters = 0;
            int counter = 0;
            int sum = 0;
            while (n > counter)
            {
                liters = int.Parse(Console.ReadLine());
                if (sum + liters <= 255)
                {
                    sum += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    counter++;
                    continue;
                }
                counter++;
            }
            Console.WriteLine(sum);
        }
    }
}
