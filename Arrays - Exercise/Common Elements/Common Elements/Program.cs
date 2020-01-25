using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstarr = Console.ReadLine().Split(' ');
            string[] secondarr = Console.ReadLine().Split(' ');
            for(int i = 0; i< secondarr.Length; i++)
            {
                string element = secondarr[i];
                for(int n = 0; n < firstarr.Length; n++)
                {
                    string currentelement = firstarr[n];
                    if (element == currentelement)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }
    }
}
