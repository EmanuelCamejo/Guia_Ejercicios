using System;
using Biblioteca;

namespace CreoQueNecesitoUnPrestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Necesito un prestamo";
            Cuenta Uno = new Cuenta("Pepe S.A.", 200, 100);

            Console.WriteLine($"{Uno.GetMostrar()}, {Uno.GetIngresar()}, {Uno.GetRetirar()}");

            
        }
    }
}
