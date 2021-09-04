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

            Console.WriteLine("Debera ingresar 10 números en el rango -100 y 100, y sabras el minimo, maximo y el promedio\n");

            while (contNumeros < 10)
            {
                Console.WriteLine("Ingrese numero");
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
                        Console.WriteLine("ESTE NÚMERO NO SE TOMARA EN CUANTA YA QUE ESTA FUERA DEL RANGO SOLICITADO");
                    }
                }
                else
                {
                    Console.WriteLine("NO SE TOMARA EN CUANTA YA QUE LO INGRESADO NO ES UN NÚMERO");
                }
                contNumeros++;
            }
            prom = acumNumero / 10;

            Console.WriteLine("\nEl maximo es {0}, el minimo es {1}, el promedio es {2}", valorMax, ValorMin, prom);
        }
    }
}
