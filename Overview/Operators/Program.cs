﻿using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x=10, y=5;
            string a="abcd", b="efgh";

            // TODO: Basic math operators are +, -, /, *
            Console.WriteLine("----- Basic Math -----");
            Console.WriteLine(x/y);
            Console.WriteLine(a+b);


            // TODO: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            Console.WriteLine("{0}  {1}",x++, y--);

            // TODO: Operators can be shorthand: a = a + b


            // TODO: Logical operators &&, ||
            // Console.WriteLine("----- Logic Operators -----");


            // null-coalescing operators
            // string str = null;
            // TODO: the ?? operator uses left operand if not null, or right one if it is
            string str = null;
            Console.WriteLine(str ?? "The string was empty");

            // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }
            str ??= "was null";
            Console.WriteLine(str);
        }
    }
}
