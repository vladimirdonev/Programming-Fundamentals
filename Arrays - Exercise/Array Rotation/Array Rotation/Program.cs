using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            for(int i = 0; i < rotation; i++)
            {
                int firstnumber = number[0];
                for(int j = 0; i < number.Length - 1; j++)
                {
                    number[j] = number[j + 1];
                }
                number[number.Length - 1] = firstnumber; 
            }
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
