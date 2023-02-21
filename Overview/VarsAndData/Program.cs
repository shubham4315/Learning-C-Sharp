using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // TODO: Declare an array of values
            int[] vals = new int[5];
            string[] strs = {"one", "two", "three"};

            // TODO: Print the values using a Formatting String
            Console.WriteLine("{0}, {1}, {2}", i, c, b);

            // TODO: "null" means "no value"
            Object obj = null;
            Console.WriteLine(obj);

            // TODO: Implicit conversion between types
            long bignum = i;
            Console.WriteLine(bignum);

            // TODO: Explicit conversions
            float i_to_f = (float)i;
            int f_to_i = (int)f;
            Console.WriteLine("{0} {1}", i_to_f, f_to_i);
        }
    }
}
