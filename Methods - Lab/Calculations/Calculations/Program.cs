using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            if (command == "add")
            {
                add(firstnumber, secondnumber);
            }
            if (command == "subtract")
            {
                subtract(firstnumber, secondnumber);
            }
            if (command == "divide")
            {
                divide(firstnumber, secondnumber);
            }
            if (command == "multiply")
            {
                multiply(firstnumber, secondnumber);
            }
        }
        private static void add(int firstnumber, int secondnumber)
        {

            Console.WriteLine(firstnumber + secondnumber);
        }
        private static void subtract(int firstnumber, int secondnumber)
        {

            Console.WriteLine(firstnumber - secondnumber);
        }
        private static void divide(int firstnumber, int secondnumber)
        {

            Console.WriteLine(firstnumber / secondnumber);
        }
        private static void multiply(int firstnumber, int secondnumber)
        {

            Console.WriteLine(firstnumber * secondnumber);
        }
    }
}
