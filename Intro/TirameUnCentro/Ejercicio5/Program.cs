using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num;
            Console.WriteLine("Ingrese un número para saber cuales son centro númerico");
            int num = int.Parse(Console.ReadLine());

            int acum=0,acum2=0,centroNumerico;
            
            for (int i = 1; i <= num; i++)
            {
                acum += i;
                acum2 = 0;
                for (int j=i+2; j <=num; j++)
                {
                    acum2 += j;
                    if (acum == acum2)
                    {
                        centroNumerico = i + 1;
                        Console.WriteLine(centroNumerico);
                    }
                }




            }
        }
    }
}
