using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            for (int i = 0; i < 3; i++)
            {
                string inutpassword = Console.ReadLine();
                if (password == inutpassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            string lastpasword = Console.ReadLine();
            if (lastpasword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
