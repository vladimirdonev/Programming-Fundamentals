using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder encryptedmessege = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                string currentword = word[i].ToString();
                for (int j = 0; j < currentword.Length; j++)
                {
                    string letter = currentword[j].ToString();
                    for (int k = 0; k < letter.Length; k++)
                    {
                        char plus3 = letter[k];
                        int newvalue = plus3 + 3;
                        char newword = (char)newvalue;
                        encryptedmessege.Append(newword);
                    }
                }

            }
            Console.WriteLine(encryptedmessege);
        }
    }
}
