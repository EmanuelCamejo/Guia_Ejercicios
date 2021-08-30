using System;
using Biblioteca;

namespace CreoQueNecesitoUnPrestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta Uno = new Cuenta("Pepe S.A.", 200, 100);

            
            Console.WriteLine($"{Uno.GetMostrar()}");
        }
    }
}
