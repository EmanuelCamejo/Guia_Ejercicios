using System;
using Biblioteca;

namespace FizzBuzzExtendido
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num = 3;
            string resultado=num.FizzBuzz();
            Console.WriteLine(resultado);
        }
    }
}
