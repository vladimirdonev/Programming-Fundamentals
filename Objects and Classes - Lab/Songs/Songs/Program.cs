using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i <= n - 1; i++)
            {
                string[] song = Console.ReadLine().Split('_').ToArray();
                string Type = song[0];
                string Name = song[1];
                string Time = song[2];
                Song songss = new Song();
                songss.type = Type;
                songss.name = Name;
                songss.time = Time;
                songs.Add(songss);
            }
            string typelist = Console.ReadLine();
            if (typelist == "all")
            {
                foreach (Song songss in songs)
                {
                    Console.WriteLine(songss.name);
                }
            }
            else
            {
                foreach (Song songss in songs)
                {
                    if (songss.type == typelist)
                    {


                        Console.WriteLine(songss.name);
                    }
                }
            }
        }
    }
}
class Song
{
    public string type { get; set; }
    public string name { get; set; }
    public string time { get; set; }
}