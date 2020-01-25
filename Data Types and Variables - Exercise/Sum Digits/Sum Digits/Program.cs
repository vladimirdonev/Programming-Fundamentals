using System;
using System.Linq;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Select(x => {
                if (int.TryParse(x.ToString(), out int result))
                {
                    return result;
                }
                else
                {
                    return -1;
                }
            }).Where(x => x != -1).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
