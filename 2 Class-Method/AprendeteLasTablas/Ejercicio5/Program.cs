using System;
using System.Text;


namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero para saber su tabla");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine($"\nTabla de multiplicar del número {num1}:");
            Console.WriteLine(CalcularTabla(num1));
        }

        public static string CalcularTabla(int num)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.AppendLine($"{num} x {i} = {num * i}");                
            }            
            return stringBuilder.ToString();
        }

    }
    
}
