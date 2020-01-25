using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) + 'a';
            for (char i = 'a'; i < n; i++)
            {
                for (char k = 'a'; k < n; k++)
                {
                    for (char j = 'a'; j < n; j++)
                    {
                        string letters = "" + i + k + j;
                        Console.WriteLine(letters);
                    }
                }
            }

        }
    }
}