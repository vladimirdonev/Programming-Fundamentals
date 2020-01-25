using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string explosivi = Console.ReadLine();
            int bomb = 0;
            for (int i = 0; i < explosivi.Length; i++)
            {
                if (bomb > 0 && explosivi[i] != '>')
                {
                    explosivi = explosivi.Remove(i, 1); // Remove char on this index
                    bomb--; // One bomb is used
                    i--; // after remove next char is moved 1 position, so return counter i to this char, decreasing i by 1  
                }
                else if (explosivi[i] == '>')
                {
                    bomb += int.Parse(explosivi[i + 1].ToString()); // takes the digit after '>' - bomb strength and add to bomb
                }
            }
            Console.WriteLine(explosivi);
        }
    }
}
