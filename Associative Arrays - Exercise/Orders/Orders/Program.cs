using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        public static void Main()
        {
            string command = null;
            var orders = new Dictionary<string, priceandquantities>();
            string oldresource = null;

            while (command != "buy")
            {
                command = Console.ReadLine();
                if (command == "buy")
                {
                    break;
                }
                string[] splitedinput = command.Split(' ');
                string name = splitedinput[0];
                double price = double.Parse(splitedinput[1]);
                int quantity = int.Parse(splitedinput[2]);
                priceandquantities priceandquantities = new priceandquantities();
                priceandquantities.price = price;
                priceandquantities.quantities = quantity;
                if (!orders.ContainsKey(name))
                {
                    orders.Add(name, priceandquantities);
                }
                else
                {
                    orders[name].price = price;
                    orders[name].quantities += quantity;
                }
            }
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
        class priceandquantities
        {
            public double price { get; set; }
            public int quantities { get; set; }
            public override string ToString()
            {
                return $"{price * quantities:f2}";
            }
        }
    }
}