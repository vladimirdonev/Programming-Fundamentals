using System;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int rnd2 = rnd.Next(words.Length);
                if (i != rnd2)
                {
                    var old = words[i];
                    words[i] = words[rnd2];
                    words[rnd2] = old;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
