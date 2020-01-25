using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }
            while (times <= 10);
        }
    }
}
