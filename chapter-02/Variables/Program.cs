using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object type
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object

            Console.WriteLine($"{name} is {height} meters tall.");

            // int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length; // tell compiler it is a string

            Console.WriteLine($"{name} has {length2} characters.");

            // Dynamic type
            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";

            // this compilesx but would throw an exception at run-time if you later 
            // store a data type that does not have a property named Length
            int length = anotherName.Length;


            // Local Variables
            Console.WriteLine("\n\nLocal Variables\n\n");

            // int population = 66_000_000; // 66 million in the UK
            // double weight = 1.88; // in kilograms
            // decimal price = 4.99M; // in pounds sterling
            // string fruit = "Apples"; // strings us double-quotes
            // char letter = 'Z'; // char uses single-quotes
            // bool happy = true; // booleans have value of true or false

            // re-written to use var (which infers type based on the value)
            var population = 66_000_000; // 66 million in the UK
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings us double-quotes
            var letter = 'Z'; // char uses single-quotes
            var happy = true; // booleans have value of true or false



        }
    }
}
