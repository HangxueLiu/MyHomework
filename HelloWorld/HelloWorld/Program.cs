﻿using System;

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
            foreach(string i in args)
            {
                Console.Write(i);
            }
            Console.WriteLine();
           HelloWorld hello=new HelloWorld();
            hello.PrintHello();
            foreach (string i in args)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
