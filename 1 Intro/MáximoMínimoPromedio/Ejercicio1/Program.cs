using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int acum = 0;
            decimal prom = 0.0M;
            //float prom = 0.0F;
            int num = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresar un número");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                    acum += num;
                }
                else
                {
                    Console.WriteLine("Esto no es un número \n");
                }

            }
            prom = acum / 5;
            Console.WriteLine("\nEl valor maximo ingresado es: {0}, el minimo es: {1}, y el promedio es: {2:N1}",max,min,prom);

        }
    }
}
