using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var Words = Console.ReadLine().Split(' ');
            var count = new Dictionary<string, int>();
            foreach (var word in Words)
            {
                string wordsInLowerCase = word.ToLower();
                if (count.ContainsKey(wordsInLowerCase))
                {
                    count[wordsInLowerCase]++;
                }
                else
                {
                    count.Add(wordsInLowerCase, 1);
                }
            }
            foreach (var item in count)
            {
                if (item.Value % 2 == 0)
                {

                }
                else
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
