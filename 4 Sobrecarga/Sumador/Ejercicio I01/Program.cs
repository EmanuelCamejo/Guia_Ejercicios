using System;
using Biblioteca;

namespace Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(2);

            s1.Sumar("Hola", " Chau");
            s2.Sumar(5, 5);

            Console.WriteLine($"{s1+s2}");
            Console.WriteLine($"{s1|s2}");
        }
    }
}
