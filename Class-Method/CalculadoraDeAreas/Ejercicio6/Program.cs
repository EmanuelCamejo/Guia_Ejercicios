using System;
using System.Text;
using Biblioteca;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int opcion=0;
            char respuesta = 's';
            StringBuilder stringBuilder = new StringBuilder();

            while (respuesta == 's' || respuesta =='S')
            {
                Console.WriteLine("Ingreses 1 si desea calcular el area de un cuadrado");
                Console.WriteLine("Ingreses 2 si desea calcular el area de un triangulo");
                Console.WriteLine("Ingreses 3 si desea calcular el area de un circulo");
                bool opcion = int.TryParse(Console.ReadLine(),out int num);
                if (opcion == true)
                {


                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese el valor de uno de sus lados");
                            double lado = double.Parse(Console.ReadLine());
                            stringBuilder.AppendLine($"El Area del cuadrado es: {CalculadoraDeArea.CalcularAreaCuadrado(lado)}");
                            Console.WriteLine(stringBuilder.ToString());
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el valor de la base");
                            double basse = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor de la altura");
                            double altura = double.Parse(Console.ReadLine());
                            stringBuilder.AppendLine($"El Area del triangulo es: {CalculadoraDeArea.CalcularAreaTriangulo(basse, altura)} ");
                            Console.WriteLine(stringBuilder.ToString());
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el valor del Radio del Ciculo");
                            double radio = double.Parse(Console.ReadLine());
                            stringBuilder.AppendLine($"El Area del Circulo es: {CalculadoraDeArea.CalcularAreaCirculo(radio)} ");
                            Console.WriteLine(stringBuilder.ToString());
                            break;
                        default:
                            Console.WriteLine("No ingreso ninguna de las opciones");
                            Console.WriteLine("Desea seguir S/N");
                            respuesta = char.Parse(Console.ReadLine());
                            break;
                    }
                    Console.WriteLine("Desea seguir calculando areas S/N");
                    respuesta = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("No ingreso un número, desea Calcular otro tipo de area S/N");
                    respuesta = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"\nResumen de todas las areas calculadas\n{stringBuilder.ToString()}");
        }
    }
}
