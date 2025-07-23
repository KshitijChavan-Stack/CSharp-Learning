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

            // User Input Example
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine(); // reading input from the console
            Console.WriteLine("Hello, " + name + "! Welcome to C# programming.");
            Console.WriteLine("How many Candy do you want?: ");
            string candys = Console.ReadLine();
            Console.WriteLine("Thanks for ordering, you'll get 4 more candys: "+ (Convert.ToInt32(candys) + 4));
            // if any on the lines in writeline becomes string, all the lines will become string
            // this is because of the + operator, it concatenates the strings
            // so we add them opertion into the brackets to make sure it is evaluated first(priority)

            // OPERATORS IN C#
            // Arithmetic Operations Example

            int a01 = 10;
            int b01 = 20;
            Console.WriteLine("The Value of a + b is: " + (a + b)); // addition
            Console.WriteLine("The Value of a - b is: " + (a - b)); // subtraction  
            Console.WriteLine("The Value of a * b is: " + (a * b)); // multiplication
            Console.WriteLine("The Value of a / b is: " + (a / b)); // division

            //Assignment Operations Example
            int c = 10;
            int d = 20;
            c += d; // c = c + d
            c -= d; // c = c - d
            c *= d; // c = c * d
            c /= d; // c = c / d

            // Logical Operations Example
            Console.WriteLine(true && false); // AND operation  
            Console.WriteLine(true || false); // OR operation
            Console.WriteLine(!true); // NOT operation

            // Comparison Operations Example
            Console.WriteLine(a == b); // equal to
            Console.WriteLine(a != b); // not equal to
            Console.WriteLine(a > b); // greater than
            Console.WriteLine(a < b); // less than
            Console.WriteLine(a >= b); // greater than or equal to
            Console.WriteLine(a <= b); // less than or equal to


            // Math class Example

            int num1 = Math.Max(10, 20); // returns the maximum of two numbers
            int num2 = Math.Min(10, 20); // returns the minimum of two numbers
            double num3 = Math.Sqrt(25); // returns the square root of a number
            double num4 = Math.Pow(2, 3); // returns the power of a number
            int num5 = Math.Abs(-10); // returns the absolute value of a number

            // String Methods Example

            string str = "Hello, World!";
            Console.WriteLine(str.Length); // returns the length of the string
            Console.WriteLine(str.ToUpper()); // converts the string to uppercase
            Console.WriteLine(str.ToLower()); // converts the string to lowercase

            // String interpolation Example

            const string greeting = "Heyy";
            const string name1 = "jojo";
            Console.WriteLine($"{greeting}, {name1}!"); // using string interpolation to format the string

            // Indexing Example
            string sample = "Hello, World!";
            Console.WriteLine(sample[0]); // prints the first character of the string
            Console.WriteLine(sample.IndexOf("World")); // finds the start index of the string 'World' in the string
            string sub = sample.Substring(7, 5); // extracts a substring from the string starting at index 7 and of length 5
            // old string wont change, it will create a new string

            // Escape Sequences Example

            Console.WriteLine("Hello, \"World\"!"); // prints Hello, "World"!
            Console.WriteLine("Hello, \nWorld!"); // prints Hello, 
                                                  // World! (new line)
            Console.WriteLine("Hello, \tWorld!"); // prints Hello,     World! (tab space)


            Console.ReadLine();
        }

    }
}
// this is a simple C# program that demonstrates the use of variables, data types, typecasting, and input/output in C#.