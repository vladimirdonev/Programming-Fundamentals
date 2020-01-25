using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            List<string> filteredlist = words.Where(x => x.Length % 2 == 0).ToList();
            foreach (string word in filteredlist)
            {
                Console.WriteLine(word);
            }
        }
    }
}
