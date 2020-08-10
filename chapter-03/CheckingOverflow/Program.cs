using System;
using static System.Console;

namespace CheckingOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After incrementing: x = {x}");
                    x++;
                    WriteLine($"After incrementing: x = {x}");
                    x++;
                    WriteLine($"After incrementing: x = {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I caught the exception.");
            }

            WriteLine();
            WriteLine();
            // pg 104 disable compiler overflow checks
            unchecked
            {
                int y = int.MaxValue + 1;

                WriteLine($"Initial value: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
                y--;
                WriteLine($"After decrementing: {y}");
            }

            WriteLine();
            WriteLine();

            double test = 45;
            WriteLine($"{test / 0}");
        }
    }
}
