using System;
using Biblioteca;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la Razon Social");
            string razonSocial=Console.ReadLine();
            Console.WriteLine("Que monto desea agregar a su cuenta");
            double monto = double.Parse(Console.ReadLine());
            
            Cuenta c1 = new Cuenta(razonSocial, monto);
            Console.WriteLine(c1.Mostrar());

            c1.Ingresar(100);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(50);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(10000);
            Console.WriteLine(c1.Mostrar());

        }
    }
}
