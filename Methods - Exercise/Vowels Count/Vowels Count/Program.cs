using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int count = 0;
            char[] vowels = { 'o', 'i', 'a', 'u', 'e', 'U' };
            for (int i = 0; i < word.Length; i++)
            {
                int curentsumbol = word[i];
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (curentsumbol == vowels[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
