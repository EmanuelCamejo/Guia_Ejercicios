using System;
using Biblioteca;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("              CALCULADORA\n");
            char respuesta = 's';
            while (respuesta=='s' || respuesta=='S')
            {
                Console.WriteLine("\nIngrese el primer número");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Operacion (+,-,*,/)");
                char operacion = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el primer número");
                double num2 = double.Parse(Console.ReadLine());
                double resultado = Calculadora.Calcular(num1, operacion, num2);

                Console.WriteLine("\nEl resultado es: {0}", resultado);

                Console.WriteLine("\nDeseacontinuar S/N\n");
                respuesta = char.Parse(Console.ReadLine());

            }
           
        }
    }
}
