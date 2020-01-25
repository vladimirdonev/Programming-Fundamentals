using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
                byte age = byte.Parse(Console.ReadLine());
                if (age == 0 || age <= 2)
                {
                    Console.WriteLine("baby");
                }
                else if (3 == age || age <= 13)
                {
                    Console.WriteLine("child");
                }
                else if (14 == age || age <= 19)
                {
                    Console.WriteLine("teeneger");
                }
                else if (20 == age || age <= 65)
                {
                    Console.WriteLine("adult");
                }
                else if (age >= 66)
                {
                    Console.WriteLine("elder");
                }
            
        }
    }
}
