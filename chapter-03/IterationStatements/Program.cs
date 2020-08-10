using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // // pg 86
            // int x = 0;

            // while (x < 10)
            // {
            //     WriteLine(x);
            //     x++;
            // }

            // // pg 87
            // string password = string.Empty;
            // int attempts = 0;
            // do
            // {
            //     Write("Enter your password: ");
            //     password = ReadLine();
            //     attempts++;
            //     WriteLine($"{attempts} attempts");

            // } while (password != "Pa$$w0rd" && attempts < 10);
            // if (attempts >= 10)
            // {
            //     WriteLine("Too many attempts. You're now locked out FOREVER!!!");
            // }
            // else
            // {
            //     WriteLine("Correct!");
            // }

            // // pg 88
            // for (int y = 1; y <= 10; y++)
            // {
            //     WriteLine(y);
            // }
            
            // pg 88
            string[] names = {"Adam", "Barry", "Charlie"};

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
