using System;
using System.Linq;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while (command != "END")
            {
                command = Console.ReadLine();
                string reverse = new string(command.ToCharArray().Reverse().ToArray());
                if (command == "END")
                {
                    break;
                }
                if (command == reverse)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
}
