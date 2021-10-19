using System;
using Biblioteca;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int acum = 0;
            string respuesta;

            do
            {
                Console.WriteLine("Ingresar un número entero para ser sumado");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    acum += num;
                }
                else
                {
                    Console.WriteLine("Error, Reingrese un número\n");
                }
                Console.WriteLine("¿Desea continuar? (S/N)");
                respuesta = Console.ReadLine();
                
                Console.WriteLine();

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine("La suma de los números ingresados es: {0}",acum);

        }
    }
}
