using System;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string newword = new string(command.Reverse().ToArray());

                Console.WriteLine($"{command} = {newword}");
            }
        }
    }
}
