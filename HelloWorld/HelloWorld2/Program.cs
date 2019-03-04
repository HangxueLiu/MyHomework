using System;

namespace HelloWorld
{
    class HelloWorld
    {
        public static void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            foreach (string i in args)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            HelloWorld.PrintHello();
            foreach (string i in args)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}