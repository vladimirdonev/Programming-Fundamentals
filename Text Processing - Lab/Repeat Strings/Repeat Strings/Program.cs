using System;
using System.Text;

namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (var texts in text)
            {
                int repeat = texts.Length;
                for (int i = 0; i < repeat; i++)
                {
                    result.Append(texts);
                }
            }

            Console.WriteLine(result);
        }
    }
}
