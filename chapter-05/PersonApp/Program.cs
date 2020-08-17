using System;
using Packt.Shared;
using static System.Console;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            WriteLine(bob.ToString());
        }
    }
}
