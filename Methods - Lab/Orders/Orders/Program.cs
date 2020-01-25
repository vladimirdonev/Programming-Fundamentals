using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                coffee(amount);
            }
            else if (product == "coke")
            {
                coke(amount);
            }
            else if (product == "snack")
            {
                snack(amount);
            }
            else if (product == "water")
            {
                water(amount);
            }
        }
        static void coffee(double amount)
        {
            double coffee = 1.50;
            Console.WriteLine($"{amount * coffee:f02}");
        }
        static void water(double amount)
        {
            double water = 1.00;
            Console.WriteLine($"{amount * water:f02}");
        }
        static void snack(double amount)
        {
            double snack = 2.00;
            Console.WriteLine($"{amount * snack:f02}");
        }
        static void coke(double amount)
        {
            double coke = 1.40;
            Console.WriteLine($"{amount * coke:f02}");
        }
    }
}
