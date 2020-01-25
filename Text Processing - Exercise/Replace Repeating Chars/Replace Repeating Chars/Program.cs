using System;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            int count = 0;
            string previousletter = null;
            for (int i = 0; i < sequence.Length; i++)
            {
                previousletter = sequence[i].ToString();
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    string letter = sequence[j].ToString();
                    if (previousletter == letter)
                    {
                        count++;
                    }
                    else
                    {
                        sequence = sequence.Remove(i, count);
                        count = 0;
                        break;
                    }
                }
                if (count > 0)
                {
                    sequence = sequence.Remove(i, count);
                }

            }
            Console.WriteLine(sequence);
        }
    }
}
