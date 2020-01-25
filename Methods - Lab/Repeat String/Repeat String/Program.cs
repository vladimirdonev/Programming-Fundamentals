using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            repeat(n, word);
        }
        static void repeat(int n, string word)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(word);
            }
        }
    }
}
