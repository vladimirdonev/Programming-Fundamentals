using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            firstsum(a, b);
            int sum = firstsum(a, b) - c;
            Console.WriteLine(sum);
        }
        static int firstsum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
