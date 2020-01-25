using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        public static void Main()
        {
            var Studentsandgrades = new Dictionary<string, List<double>>();
            var grades = new List<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string Studentname = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!Studentsandgrades.ContainsKey(Studentname))
                {
                    Studentsandgrades.Add(Studentname, grades);
                    Studentsandgrades[Studentname].Add(grade);
                    grades = new List<double>();
                }
                else
                {
                    Studentsandgrades[Studentname].Add(grade);
                }
            }
            var list = Studentsandgrades.OrderByDescending(x => x.Value.Average());
            foreach (var item in list)
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value.OrderByDescending(x => x).Average());
                }
            }

        }
    }
}
