using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        public static void Main()
        {
            string command = null;
            var Program = new Dictionary<string, List<string>>();
            var student = new List<string>();

            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] splitedinput = command.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                string currentcurse = splitedinput[0];
                string studentname = splitedinput[1];
                if (!Program.ContainsKey(currentcurse))
                {
                    Program.Add(currentcurse, student);
                    Program[currentcurse].Add(studentname);
                    student = new List<string>();
                }
                else
                {
                    Program[currentcurse].Add(studentname);
                }
            }
            foreach (var item in Program.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value.Count);
                foreach (var user in item.Value.OrderBy(n => n))
                {
                    Console.WriteLine("-- {0}", user);
                }
            }
        }

    }
}