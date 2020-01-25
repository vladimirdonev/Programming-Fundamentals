using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command = string.Empty;
            int Age = 0;
            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    people = people.OrderBy(x => x.Age).ToList();
                    people.ForEach(y => Console.WriteLine(y));
                    break;
                }
                string[] splitedinput = command.Split(' ');
                string Name = splitedinput[0];
                string ID = splitedinput[1];
                Age = int.Parse(splitedinput[2]);
                Person person = new Person();
                person.Name = Name;
                person.ID = ID;
                person.Age = Age;
                people.Add(person);

            }
        }
    }
}
class Person
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"{Name} with ID: {ID} is {Age} years old.";
    }
}