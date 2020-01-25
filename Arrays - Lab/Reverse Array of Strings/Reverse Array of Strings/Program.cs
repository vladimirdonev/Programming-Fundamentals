using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var arr = input;

            var reverse = arr.Reverse();
            Console.WriteLine(string.Join(" ", reverse));
        }
    }
}
