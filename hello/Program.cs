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


            // Typecasting example

            int a = 20;
            float b = 30.2f; // by default, floating point numbers are double in C# so we need to use 'f' to specify it as float
            Console.WriteLine(a);
            Console.WriteLine(b);

            // explicit typecasting from int to float
            int a1 = (int)3.5; // explicit typecasting from float to int
            Console.WriteLine(a1);

            // implicit typecasting
            // char to int to long to float to double

            int x = 2;
            double y = x; // implicit typecasting promotion from int to double
            Console.WriteLine(y);
            // int z = y;
            // this cannot be done as it cannot be demoted
            
            int z = 'Y';
            // this can be done but it'll show the ASCII value of 'Y' which is 89
            Console.WriteLine(z);

            //EXPLECIT TYPECASTING
            int w = (int)3.5; // explicit typecasting from float to int
            double v = (double)22.6; // explicit typecasting from char to int


            //TYPECASTING USING METHODS
            int L = 33;
            double m = Convert.ToDouble(L); // using Convert class to convert int to double
            /*
             * Conevert class is used to convert data types in C#
             * Convert.ToInt32() - converts to int
             * Convert.ToDouble() - converts to double
             * Convert.ToString() - converts to string
             * Convert.ToBoolean() - converts to bool
             */
            Console.ReadLine();
        }

    }
}
// this is a simple C# program that demonstrates the use of variables, data types, typecasting, and input/output in C#.