using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max = 500;
            if (max <= byte.MaxValue)
            {
                for (byte i = 0; i < max; i++)
                {
                    WriteLine(i);
                }
                // the problem here is that type "byte" maxes out at 255 creating an infinite loop
            }
            else 
            {
                WriteLine("max is greater than the max value that can be stored in type byte");
            }
        }
    }
}
