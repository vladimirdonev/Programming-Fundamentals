using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            text = text.Replace(word, string.Empty);
            text = text.Replace(word, null);
            Console.WriteLine(text);
        }
    }
}
