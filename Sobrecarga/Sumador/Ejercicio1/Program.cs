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
            int cantSumas1 = (int)s1;
            int cantSumas2 = (int)s2;

            Console.WriteLine(s1.Sumar(5,5));
            Console.WriteLine(s2.Sumar("Hola","Mundo"));
            Console.WriteLine($"{cantSumas1}");
            Console.WriteLine($"{cantSumas2}");

            Console.WriteLine(s1+s2);
            Console.WriteLine(s1|s2);

        }
    }
}
