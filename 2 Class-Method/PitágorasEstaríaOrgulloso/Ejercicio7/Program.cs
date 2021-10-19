using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Pitágoras estaría orgulloso\n");

            Console.WriteLine("Ingrese la base del triangulo a calcular");
            double basse = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo a calcular");
            double altura = double.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(Math.Pow(2, basse) + Math.Pow(2, altura));

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
