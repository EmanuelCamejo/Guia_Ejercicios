using System;
using Biblioteca;


namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(5);

            Sumador s2 = new Sumador();

            Console.WriteLine(s1.Sumar(5,5));
            Console.WriteLine(s2.Sumar("Hola","Mundo"));

        }
    }
}
