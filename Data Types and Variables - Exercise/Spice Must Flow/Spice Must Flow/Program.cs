using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingyield = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalmained = 0;
            if (startingyield >= 100)
            {
                while (startingyield >= 100)
                {
                    totalmained += startingyield - 26;
                    startingyield -= 10;
                    counter++;
                }

                totalmained -= 26;
                Console.WriteLine(counter);
                Console.WriteLine(totalmained);
            }
            else
            {
                Console.WriteLine(counter);
                Console.WriteLine(totalmained);
            }
        }
    }
}
