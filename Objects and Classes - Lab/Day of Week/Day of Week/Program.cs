using System;
using System.Globalization;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string getdate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(getdate, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
