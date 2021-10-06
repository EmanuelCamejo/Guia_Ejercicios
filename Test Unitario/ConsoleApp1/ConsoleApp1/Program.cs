using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 5;            
            int num3 = 8;            
            int num4 = 4;            
            Console.WriteLine(num1.FizzBuzz());
            Console.WriteLine(num2.FizzBuzz());
            Console.WriteLine(num3.FizzBuzz());
            Console.WriteLine(num4.FizzBuzz());
        }
    }
}
