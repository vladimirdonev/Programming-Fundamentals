using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Directory = Console.ReadLine().Split(new string[] { "\\", "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int last = Directory.Count;
            string Filename = Directory[Directory.Count - 2];
            string Fileextension = Directory.Last();
            Console.WriteLine($"File name: {Filename}\nFile extension: {Fileextension}");
        }
    }
}
