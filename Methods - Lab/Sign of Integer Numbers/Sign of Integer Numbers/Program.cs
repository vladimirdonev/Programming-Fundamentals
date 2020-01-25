using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number == "0")
            {
                Console.WriteLine($"The number {number} is zero.");
                return;
            }
            if (number.Contains("-"))
            {
                Console.WriteLine($"The number {number} is negative.");
                return;
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
                return;
            }
        }
    }
}
