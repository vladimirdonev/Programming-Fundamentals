using System;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        public static void Main()
        {
            string command = null;
            var company = new SortedDictionary<string, List<string>>();
            var companyusers = new List<string>();
            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] splitedinput = command.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string companyname = splitedinput[0];
                string companyuser = splitedinput[1];
                if (!company.ContainsKey(companyname))
                {
                    company.Add(companyname, companyusers);
                    companyusers.Add(companyuser);
                    companyusers = new List<string>();
                }
                else
                {
                    if (!company[companyname].Contains(companyuser))
                    {
                        company[companyname].Add(companyuser);
                    }
                }
            }
            foreach (var item in company)
            {
                Console.WriteLine("{0}", item.Key);
                foreach (var name in item.Value)
                {
                    Console.WriteLine("--{0}", name);
                }
            }
        }
    }
}
