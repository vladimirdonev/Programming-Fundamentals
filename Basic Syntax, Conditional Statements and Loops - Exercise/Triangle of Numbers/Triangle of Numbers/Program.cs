﻿using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++) // <=

            {
                //Console.WriteLine(row);
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");// + " "

                }
                Console.WriteLine();
            }
        }
    }
}
