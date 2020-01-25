using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string visitors = Console.ReadLine();
            string day = Console.ReadLine();
            double discount = 0;
            double total = 0;
            double totalplusdiscount = 0;
            if(visitors == "Students")
            {
                if(day == "Friday")
                {
                    double price = 8.45;
                    double totalprice = price * number;
                    total = totalprice;
                    if(number >= 30)
                    {
                        discount = totalprice * 0.15;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
                else if(day == "Saturday")
                {
                    double price = 9.8;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number >= 30)
                    {
                        discount = totalprice * 0.15;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
                else if(day == "Sunday")
                {
                    double price = 10.46;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number >= 30)
                    {
                        discount = totalprice * 0.15;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                        
                    }
                }
            }
            else if (visitors == "Business")
            {
                if (day == "Friday")
                {
                    double price = 10.9;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number >= 100)
                    {
                        discount = 10 * price;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
                else if (day == "Saturday")
                {
                    double price = 15.6;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number >= 100)
                    {
                        discount = 10 * price;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
                else if (day == "Sunday")
                {
                    double price = 16;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number >= 100)
                    {
                        discount = 10 * price;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
            }
            else if(visitors == "Regular")
            {
                if (day == "Friday")
                {
                    double price = 15;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number <= 10 || number <= 20)
                    {
                         discount = 0.05 * totalprice;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
                else if (day == "Saturday")
                {
                    double price = 20;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number <= 10 || number <= 20)
                    {
                         discount = 0.05 * totalprice;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
                else if (day == "Sunday")
                {
                    double price = 22.5;
                    double totalprice = price * number;
                    total = totalprice;
                    if (number <= 10 || number <= 20)
                    {
                         discount = 0.05 * totalprice;
                        totalprice -= discount;
                        totalplusdiscount = totalprice;
                    }
                }
            }
            if(discount > 0)
            {
                Console.WriteLine($"Total price: {totalplusdiscount:f02}");
            }
            else
            {
                Console.WriteLine($"Total price: {total:f02}");
            }
        }
    }
}
