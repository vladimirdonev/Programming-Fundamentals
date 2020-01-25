using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            char a;
            while (n > 0)
            {
                 a = char.Parse(Console.ReadLine());

                
                sum += a;
                n--;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
