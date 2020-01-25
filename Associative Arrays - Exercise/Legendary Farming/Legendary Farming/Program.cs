using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        public static void Main()
        {
            var goodmaterials = new Dictionary<string, int>();
            goodmaterials["shards"] = 0;
            goodmaterials["fragments"] = 0;
            goodmaterials["motes"] = 0;
            var junk = new SortedDictionary<string, int>();
            bool hastobreak = false;
            int number = 0;
            string material = null;
            while (true)
            {
                string[] givenmaterials = Console.ReadLine().Split(' ');
                for (int i = 0; i < givenmaterials.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        number = int.Parse(givenmaterials[i]);
                    }
                    else
                    {
                        material = givenmaterials[i].ToLower();
                        if (material == "shards" || material == "fragments" || material == "motes")
                        {
                            goodmaterials[material] += number;
                        }
                        else
                        {
                            if (junk.ContainsKey(material))
                            {
                                junk[material] += number;
                            }
                            else
                            {
                                junk.Add(material, number);
                            }
                        }
                        foreach (var item in goodmaterials)
                        {
                            if (item.Value >= 250)
                            {

                                hastobreak = true;
                            }

                        }
                        if (hastobreak == true)
                        {
                            break;
                        }
                    }
                }


                if (hastobreak == true)
                {
                    break;
                }
            }
            foreach (var item in goodmaterials.OrderByDescending(x => x.Value))
            {
                if (item.Key == "shards" && item.Value >= 250)
                {
                    int newnumber = item.Value - 250;
                    goodmaterials["shards"] = newnumber;
                    Console.WriteLine("Shadowmourne obtained!");
                }
                if (item.Key == "fragments" && item.Value >= 250)
                {
                    int newnumber = item.Value - 250;
                    goodmaterials["fragments"] = newnumber;
                    Console.WriteLine("Valanyr obtained!");
                }
                if (item.Key == "motes" && item.Value >= 250)
                {
                    int newnumber = item.Value - 250;
                    goodmaterials["motes"] = newnumber;
                    Console.WriteLine("Dragonwrath obtained!");
                }

            }
            Dictionary<string, int> filteredKeyMaterials = goodmaterials
                   .OrderByDescending(kvp => kvp.Value)
                   .ThenBy(kvp => kvp.Key)
                   .ToDictionary(a => a.Key, a => a.Value);
            foreach (var frags in filteredKeyMaterials)
            {

                Console.WriteLine("{0}: {1}", frags.Key, frags.Value);


            }
            foreach (var junks in junk)
            {
                Console.WriteLine("{0}: {1}", junks.Key, junks.Value);
            }
        }
    }
}