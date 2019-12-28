using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World!";
            //Use this to show in debug output
            //System.Diagnostics.Debug.WriteLine(hello);
            //Show in command prompt window
            Console.WriteLine($"{hello} My Name is Luke");
            //String Search
            Console.WriteLine(hello.Contains("Hello"));
            Console.WriteLine(hello.StartsWith("Hello"));
        }
    }
}
