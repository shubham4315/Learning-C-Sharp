// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your Name");
            string str = Console.ReadLine();
            Console.WriteLine("Hello " + str);
        }
    }
}

