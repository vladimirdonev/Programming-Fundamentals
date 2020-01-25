using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string one = words[0];
            string two = words[1];
            char first = 'a';
            char second = 'a';
            int total = 0;
            int min = Math.Min(one.Length, two.Length);
            int max = Math.Max(one.Length, two.Length);

            for (int i = 0; i < min; i++)
            {
                first = one[i];
                second = two[i];
                total += first * second;

            }

            if (one.Length != two.Length)
            {
                if (one.Length != two.Length)
                {
                    string longerInput = one.Length > two.Length ? longerInput = one : longerInput = two;
                    for (int i = min; i < max; i++)
                    {
                        total += longerInput[i];
                    }
                }

            }
            Console.WriteLine(total);
        }

    }
}