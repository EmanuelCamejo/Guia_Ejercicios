using System;
using Biblioteca;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int bin = 1010;

            //Console.WriteLine("Ingrese un número decimal para decirte cual es el binario");
            //int num = int.Parse(Console.ReadLine());


            //string binario = Conversor(num);
            //Console.WriteLine("{0}",binario);

            //Console.WriteLine("Ingrese un número Binario para decirte cual es el Decimal");
            //int num2 = int.Parse(Console.ReadLine());

            //int decimol = Conversor.ConvertirDecimalABinario(num2);
            //Console.WriteLine("{0}", decimol);

            Conversor c1 = new Conversor();
            double resulado1=c1.BinarioADecimal("1010");
            //string res2=c1.DecimalABinario(18);
            Console.WriteLine($"{resulado1}");

        }
    }
}
