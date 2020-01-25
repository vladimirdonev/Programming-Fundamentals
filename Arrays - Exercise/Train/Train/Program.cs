using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] peopleintrain = new int[n];
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                int wagons = int.Parse(Console.ReadLine());
                peopleintrain[i] = wagons;
                sum += wagons;
            }
            Console.WriteLine(string.Join(" ", peopleintrain));
            Console.WriteLine(sum);
        }
    }
}
