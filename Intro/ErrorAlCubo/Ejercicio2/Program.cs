using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool mal;


            do
            {

                Console.WriteLine("Ingresar un número mayor que 0");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0)
                    {
                        double cuadrado = Math.Pow(num, 2);
                        double cubo = Math.Pow(num, 3);
                        Console.WriteLine("\nEl cuadrado de {0} es: {1} y el cubo es: {2}", num, cuadrado, cubo);
                    }
                    else
                    {
                        Console.WriteLine("ERROR. ¡Reingresar número!\n");
                    }

                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!\n");
                }

            }
            while (num<=0);
            
        }
    }
}
