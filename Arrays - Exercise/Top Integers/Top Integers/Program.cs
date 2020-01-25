using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bigesestnumber = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for(int i  = 0; i < bigesestnumber.Length -1; i++)
            {
                int number = bigesestnumber[i];
                bool istopinteger = true;
                for(int j = i + 1; j <bigesestnumber.Length; j++)
                {
                    int nextnumber = bigesestnumber[j];
                    if(number <= nextnumber)
                    {
                        istopinteger = false;
                        break;
                    }
                }
                if (istopinteger)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine(bigesestnumber[bigesestnumber.Length - 1]);
        }
    }
}
