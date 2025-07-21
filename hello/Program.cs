using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
// namespace is used to organize code and create a scope for identifiers
// namespace is like a conatiner that holds classes, structs, enums, interfaces, and other namespaces
{
    class Program
    {
        // Main method is the entry point of the program
        static void Main(string[] args)
        {
            // Variables are used to store data that can be used later in the program.
            int jojo_age = 22; // integer variable

            // Multi line comment
            /*Data types in C#
             integer - whole numbers
                string - sequence of characters
                char - single character
                bool - true or false
                float - single-precision floating point number
                double - double-precision floating point number
            */

            string input = Console.ReadLine(); // reading input from the console
            Console.WriteLine("Hello, World! this is jojo"+jojo_age);
            Console.Write("This is C# !");
            Console.WriteLine("& i'm learning it.");
            Console.WriteLine("this is the input you entered: " + input);
            Console.ReadLine();
        }

    }
}
// This is a simple C# program that prints "Hello, World!" to the console.