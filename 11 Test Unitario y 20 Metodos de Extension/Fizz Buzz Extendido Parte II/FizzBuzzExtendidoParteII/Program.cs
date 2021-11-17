 using System;
using Biblioteca;

namespace FizzBuzzExtendidoParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Extendido Parte II");
            Console.WriteLine("Metodos de Extension y Test Unitarios");

            Int32 num = Int32.Parse(Console.ReadLine());

            MiExtension.FizzBuss(num);
            
        }
    }
}
