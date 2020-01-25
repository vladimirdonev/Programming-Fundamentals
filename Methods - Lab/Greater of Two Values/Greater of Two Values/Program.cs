using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int a = 0;
                int b = 0;
                int result = getmax(a, b);
            }
            else if (input == "char")
            {
                char a = '0';
                char b = '0';
                char result = getmaxchar(a, b);
            }
            else if (input == "string")
            {
                string a = string.Empty;
                string b = string.Empty;
                string result = getmaxstring(a, b);
            }
        }
        static int getmax(int a, int b)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
                return a;
            }
            else
            {
                Console.WriteLine(b);
                return b;
            }
        }
        static char getmaxchar(char a, char b)
        {
            a = char.Parse(Console.ReadLine());
            b = char.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
                return a;
            }
            else
            {
                Console.WriteLine(b);
                return b;
            }
        }
        static string getmaxstring(string a, string b)
        {
            a = Console.ReadLine();
            b = Console.ReadLine();
            if (a.CompareTo(b) >= 0)
            {
                Console.WriteLine(a);
                return a;
            }
            else
            {
                Console.WriteLine(b);
                return b;
            }
        }
    }
}
