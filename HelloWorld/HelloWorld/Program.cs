using System;

namespace HelloWorld
{
    class HelloWorld
    {
        public  void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello=new HelloWorld();
            hello.PrintHello();
            Console.ReadKey();
        }
    }
}
