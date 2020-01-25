using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            raisetopower(number, power);
        }
        static void raisetopower(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);

            Console.WriteLine(result);
        }
    }
}
