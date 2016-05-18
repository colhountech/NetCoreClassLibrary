using System;
using NetCoreClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter("World");
            Console.WriteLine(greeter.Greet("Hello"));
        }
    }
}
