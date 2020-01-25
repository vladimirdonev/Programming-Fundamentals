using System;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            var nums = new StringBuilder();
            var letters = new StringBuilder();
            var symbols = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (char.IsDigit(letter))
                {
                    nums.Append(letter);
                }
                if (char.IsLetter(letter))
                {
                    letters.Append(letter);
                }
                else if (!char.IsLetterOrDigit(letter))
                {
                    symbols.Append(letter);
                }
            }
            Console.WriteLine($"{nums}\n{letters}\n{symbols}");
        }
    }
}
