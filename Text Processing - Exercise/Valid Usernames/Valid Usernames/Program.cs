using System;
using System.Collections.Generic;
using System.Text;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var valid = new StringBuilder();
            List<string> validusernames = new List<string>();
            for (int i = 0; i < usernames.Length; i++)
            {
                string username = usernames[i];

                if (username.Length > 3 && username.Length < 16)
                {
                    int oldlength = username.Length;
                    foreach (var user in username)
                    {

                        if (char.IsLetterOrDigit(user) || user == '-' || user == '_')
                        {

                            valid.Append(user);
                        }
                        else
                        {

                        }

                    }
                    if (valid.Length != oldlength)
                    {
                        valid = new StringBuilder();
                    }
                    if (valid.Length > 0)
                    {
                        string users = valid.ToString();
                        validusernames.Add(users);
                        valid = new StringBuilder();
                    }
                }
            }
            foreach (var user in validusernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
