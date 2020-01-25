using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                number = int.Parse(Console.ReadLine());
                number = Math.Abs(number);
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                }
            }
        }
    }
}
