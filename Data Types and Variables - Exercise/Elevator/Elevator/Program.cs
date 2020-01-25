using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofpeople = int.Parse(Console.ReadLine());
            int cap = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberofpeople / cap);
            Console.WriteLine(courses);
        }
    }
}
