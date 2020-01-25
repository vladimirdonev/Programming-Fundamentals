using System;

namespace Factorial_Division
{
    class Program
    {
        static long DiviseNumbers(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * DiviseNumbers(n - 1));
        }

        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());

            double result = (double)DiviseNumbers(factorialNumber) / DiviseNumbers(divider);
            Console.WriteLine($"{result:f2}");
        }
    }
}
