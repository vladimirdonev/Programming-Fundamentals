using System;

namespace Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofmonth = int.Parse(Console.ReadLine());
            if (numberofmonth == 1)
            {
                Console.WriteLine("January");
            }
            else if (numberofmonth == 2)
            {
                Console.WriteLine("February");
            }
            else if (numberofmonth == 3)
            {
                Console.WriteLine("March");
            }
            else if (numberofmonth == 4)
            {
                Console.WriteLine("April");
            }
            else if (numberofmonth == 5)
            {
                Console.WriteLine("May");
            }
            else if (numberofmonth == 6)
            {
                Console.WriteLine("June");
            }
            else if (numberofmonth == 7)
            {
                Console.WriteLine("July");
            }
            else if (numberofmonth == 8)
            {
                Console.WriteLine("Agust");
            }
            else if (numberofmonth == 9)
            {
                Console.WriteLine("September");
            }
            else if (numberofmonth == 10)
            {
                Console.WriteLine("Octomber");
            }
            else if (numberofmonth == 11)
            {
                Console.WriteLine("November");
            }
            else if (numberofmonth == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
