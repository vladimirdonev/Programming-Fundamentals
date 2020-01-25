using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string command;
            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);
                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1.0:
                    case 2.0:
                        sum += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;

                }
            }
            string product;
            while ((product = Console.ReadLine()) != "End")
            {
                double price = 0;
                if (product == "Coke")
                {
                    price = 1;
                }
                else if (product == "Nuts" && sum - 2 >= 0)
                {
                    price = 2;
                }
                else if (product == "Water" && sum - 0.7 >= 0)
                {
                    price = 0.7;
                }
                else if (product == "Crisps" && sum - 1.5 >= 0)
                {
                    price = 1.5;
                }
                else if (product == "Soda" && sum - 0.8 >= 0)
                {
                    price = 0.8;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                if (sum - price >= 0)
                {
                    sum -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {sum:f02}");
        }
    }
}
