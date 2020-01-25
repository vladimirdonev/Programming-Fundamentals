using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var words in word)
            {
                if (text.Contains(words))
                {
                    text = text.Replace(words, new string('*', words.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
