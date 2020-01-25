using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            string sing = Console.ReadLine();
            int secondnumber = int.Parse(Console.ReadLine());
            domath(firstnumber, secondnumber, sing);
        }
        static void domath(int firstnumber, int secondnumber, string sing)
        {
            int result = 0;
            if (sing == "/")
            {
                result = firstnumber / secondnumber;

            }
            else if (sing == "+")
            {
                result = firstnumber + secondnumber;

            }
            else if (sing == "-")
            {
                result = firstnumber - secondnumber;

            }
            else if (sing == "*")
            {
                result = firstnumber * secondnumber;
            }
            Console.WriteLine(result);
        }
    }
}
