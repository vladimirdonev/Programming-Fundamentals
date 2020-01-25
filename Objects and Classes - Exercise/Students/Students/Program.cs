using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            double grade = 0;
            for (int i = 0; i < n; i++)
            {
                string[] splitedinput = Console.ReadLine().Split(new string[] { ":", " " }, StringSplitOptions.RemoveEmptyEntries);
                string FirstName = splitedinput[0];
                string LastName = splitedinput[1];
                grade = double.Parse(splitedinput[2]);
                Student student = new Student();
                student.Firstname = FirstName;
                student.LastName = LastName;
                student.grade = grade;
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
}
class Student
{
    public string Firstname { get; set; }
    public string LastName { get; set; }
    public double grade { get; set; }
    public override string ToString()
    {
        return $"{Firstname} {LastName}: {grade:f02}";
    }
}