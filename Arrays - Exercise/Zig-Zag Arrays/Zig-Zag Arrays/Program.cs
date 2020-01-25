using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstinteger = new int[n];
            int[] secondinteger = new int[n];
            for (int i = 0; n > i; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if(i % 2 == 0)
                {
                    firstinteger[i] = numbers[0];
                    secondinteger[i] = numbers[1];
                }
                else
                {
                    firstinteger[i] = numbers[1];
                    secondinteger[i] = numbers[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstinteger));
            Console.WriteLine(string.Join(" ", secondinteger));
        }
    }
}
