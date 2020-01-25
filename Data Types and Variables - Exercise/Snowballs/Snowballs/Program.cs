using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            double bestSnowballSnow = 0;
            double bestSnowballTime = 0;
            double bestSnowballQuality = 0;
            double SnowballValue = 0;
            double bestsnowball = 0;
            while(n > counter)
            {
                double SnowballSnow = int.Parse(Console.ReadLine());
                double SnowballTime = int.Parse(Console.ReadLine());
                double SnowballQuality = int.Parse(Console.ReadLine());
                SnowballValue = Math.Pow((SnowballSnow / SnowballTime), SnowballQuality);
                if(SnowballValue >= bestsnowball)
                {
                    bestSnowballSnow = SnowballSnow;
                    bestSnowballTime = SnowballTime;
                    bestSnowballQuality = SnowballQuality;
                    bestsnowball = SnowballValue;
                }
                counter++;
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestsnowball} ({bestSnowballQuality})");
        }
    }
}
