using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] result = new string[100]; 
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i-1] = "fizzbuzz";
                    WriteLine(result[i-1]);
                }
                else if (i % 3 == 0)
                {
                    result[i-1] = "fizz";
                    WriteLine(result[i-1]);
                }
                else if (i % 5 == 0)
                {
                    result[i-1] = "buzz";
                    WriteLine(result[i-1]);
                }
                else
                {
                    result[i-1] = i.ToString();
                    WriteLine(result[i-1]);
                }
            }
            WriteLine(result);
        }
    }
}
