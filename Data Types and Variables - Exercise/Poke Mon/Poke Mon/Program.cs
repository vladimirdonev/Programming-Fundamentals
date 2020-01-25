using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int originalvalue = n;
            int pokettargets = 0;
            while (n >= m)
            {
                
                
                    pokettargets++;
                    n = n - m;
                    if (n == originalvalue * 0.5 && y !=0)
                    {
                        n /= y;
                    }
                    
                
            }
            Console.WriteLine(n);
            Console.WriteLine(pokettargets);
        }
    }
}
