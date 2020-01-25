using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentsClass> StudentsList = new List<StudentsClass>();
            string command = string.Empty;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] splitedinput = command.Split(' ').ToArray();
                string firsname = splitedinput[0];
                string lastname = splitedinput[1];
                string age = splitedinput[2];
                string tawn = splitedinput[3];
                StudentsClass students = new StudentsClass();
                students.firstname = firsname;
                students.lastname = lastname;
                students.age = age;
                students.town = tawn;
                StudentsList.Add(students);
            }
            string lasttawn = Console.ReadLine();
            List<StudentsClass> filteredstudents = StudentsList.Where(x => x.town == lasttawn).ToList();
            foreach (var students in filteredstudents)
            {
                Console.WriteLine($"{students.firstname} {students.lastname} is {students.age} years old.");
            }
        }
    }
}
class StudentsClass
{
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string age { get; set; }
    public string town { get; set; }
}