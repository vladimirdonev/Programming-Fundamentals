using System;

namespace Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentname = Console.ReadLine();
            int studentage = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studentname}, Age: {studentage}, Grade: {grade:f02}");
        }
    }
}
