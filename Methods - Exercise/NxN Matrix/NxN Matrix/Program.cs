using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(" ");
                Console.Write(n + " ");
                for (int j = 1; j < n; j++)
                {
                    Console.Write(n + " ");
                }
            }

        }
    }
}
