using System;

namespace Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededexperience = double.Parse(Console.ReadLine());
            int countofbattles = int.Parse(Console.ReadLine());
            double totalexp = 0;
            int totalbattel = 0;
            for (int i = 1; i <= countofbattles; i++)
            {
                double expinbattle = double.Parse(Console.ReadLine());
                totalexp += expinbattle;
                if (i % 3 == 0)
                {
                    double plusexp = expinbattle * 0.15;
                    totalexp += plusexp;
                }
                if (i % 5 == 0)
                {
                    double substarcktexp = expinbattle * 0.1;
                    totalexp -= substarcktexp;
                }
                if (totalexp >= neededexperience)
                {
                    totalbattel = i;
                    break;
                }
            }
            if (totalexp >= neededexperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {totalbattel} battles.");
            }
            else
            {
                double moreexp = neededexperience - totalexp;
                Console.WriteLine($"Player was not able to collect the needed experience, {moreexp:f2} more needed.");
            }
        }
    }
}
