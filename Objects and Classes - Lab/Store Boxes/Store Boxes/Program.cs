using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<box> Product = new List<box>();

            string command = string.Empty;
            decimal Priceforaproduct = 0m;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] splitedinput = command.Split(' ').ToArray();
                string Serialnumber = splitedinput[0];
                string Item = splitedinput[1];
                decimal ItemQuantity = decimal.Parse(splitedinput[2]);
                Priceforaproduct = decimal.Parse(splitedinput[3]);
                box box = new box();
                box.SerialNumber = Serialnumber;
                box.ItemQuantity = ItemQuantity;
                box.priceforabox = ItemQuantity * Priceforaproduct;
                box.name = Item;
                box.price = Priceforaproduct;
                Product.Add(box);

            }
            List<box> sortedbox = Product.OrderBy(boxes => boxes.priceforabox).ToList();
            sortedbox.Reverse();
            foreach (box box in sortedbox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.name} - ${box.price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.priceforabox:F2}");

            }
        }
    }
}
class box
{
    public string SerialNumber { get; set; }
    public string name { get; set; }
    public decimal price { get; set; }
    public decimal ItemQuantity { get; set; }
    public decimal priceforabox { get; set; }
}