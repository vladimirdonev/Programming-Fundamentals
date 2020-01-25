using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Vehicle> vehicles = new List<Vehicle>();
            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] splitedinput = command.Split(' ');
                string Type = splitedinput[0];
                string Model = splitedinput[1];
                string Color = splitedinput[2];
                ushort HorsePower = ushort.Parse(splitedinput[3]);
                Vehicle vehicles1 = new Vehicle();
                vehicles1.Type = Type;
                vehicles1.Model = Model;
                vehicles1.Color = Color;
                vehicles1.Horsepower = HorsePower;
                vehicles.Add(vehicles1);

            }
            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }

                Console.WriteLine(vehicles.Find(x => x.Model == model));
            }
            var onlyCars = vehicles.Where(x => x.Type == "car").ToList();
            var onlyTrucks = vehicles.Where(y => y.Type == "truck").ToList();
            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (var car in onlyCars)
            {
                totalCarsHorsepower += car.Horsepower;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTrucksHorsepower += truck.Horsepower;
            }
            double averageCarsHorsepower = totalCarsHorsepower / onlyCars.Count;
            double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public ushort Horsepower { get; set; }
    public override string ToString()
    {
        string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                            $"Model: {this.Model}{Environment.NewLine}" +
                            $"Color: {this.Color}{Environment.NewLine}" +
                            $"Horsepower: {this.Horsepower}";

        return vehicleStr;
    }
}