using System;

namespace Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startnumber = int.Parse(Console.ReadLine());
            int endnumber = int.Parse(Console.ReadLine());
            int sum = startnumber;
            int number = startnumber;
            while (startnumber < endnumber)
            {
                startnumber++;
                sum += startnumber;
                Console.Write(number++);
                Console.Write(" ");
            }
            Console.WriteLine(endnumber);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
