using System;
using Biblioteca;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool esNumero;
            bool rango;
            int acumNumero = 0;
            int contNumeros = 0;
            int valorMax = int.MinValue;
            int ValorMin = int.MaxValue;
            double prom;

            while (contNumeros < 10)
            {
                Console.WriteLine("Ingrese un numero");
                esNumero = int.TryParse(Console.ReadLine(), out numero);

                if (esNumero)
                {

                    rango = Validador.Validar(numero, -100, 100);

                    if (rango)
                    {
                        if (numero > valorMax)
                        {
                            valorMax = numero;
                        }
                        if (numero < ValorMin)
                        {
                            ValorMin = numero;
                        }
                        acumNumero += numero;

                    }
                    else
                    {
                        Console.WriteLine("No esta en el rango");
                    }
                }
                else
                {
                    Console.WriteLine("Es no es un número");
                }
                contNumeros++;
            }
            prom = acumNumero / 10;

            Console.WriteLine("El maximo es {0}, el minimo es {1}, el promedio es {2}", valorMax, ValorMin, prom);
        }
    }
}
