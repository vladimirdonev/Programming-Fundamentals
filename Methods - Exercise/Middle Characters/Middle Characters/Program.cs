using System;
using System.Linq;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToArray();


            if (words.Length % 2 == 0)
            {
                char mid = words[words.Length / 2];
                char onebeforemid = words[words.Length / 2 - 1];
                Console.Write(onebeforemid);
                Console.Write(mid);
            }
            else
            {
                char mid = words[words.Length / 2];
                Console.WriteLine(mid);
            }
        }
    }
}
