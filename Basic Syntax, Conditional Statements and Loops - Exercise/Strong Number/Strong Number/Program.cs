using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nCopy = n;
            long factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            if (factoriel == nCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
