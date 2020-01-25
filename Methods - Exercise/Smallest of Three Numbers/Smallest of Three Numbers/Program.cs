using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int firstresult = smallestoftree(a, b);
            int smalestnumber = smallestoftree(firstresult, c);
            Console.WriteLine(smalestnumber);
        }
        static int smallestoftree(int firstnumber, int secondnumber)
        {
            if (firstnumber < secondnumber)
            {
                return firstnumber;
            }
            return secondnumber;
        }
    }
}
