using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte kegsCount = byte.Parse(Console.ReadLine());
            string biggestKegModel = "";
            double biggestKegVolume = 0;
            float pi = (float)Math.PI;

            while (kegsCount > 0)
            {
                string currentKegModel = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double currentVolume = (double)pi * kegRadius * kegRadius * kegHeight;
                if (currentVolume > biggestKegVolume)
                {
                    biggestKegVolume = currentVolume;
                    biggestKegModel = currentKegModel;
                }
                kegsCount--;
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
