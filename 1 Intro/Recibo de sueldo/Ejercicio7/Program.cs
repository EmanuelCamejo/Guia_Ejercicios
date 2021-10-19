using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Ingrese la cantidad de empleados a calcular el recibo de sueldo");
            int cantEmpleados = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantEmpleados; i++)
            {
                float importeHsTrabajadas = 0;
                float importeAntiguedad = 0;
                float descuento = 0.87F;
                float importeTotal = 0;

                Console.WriteLine("\n Ingrese el nombre del empleado número {0}: ",i);
                string nomEmpleado = Console.ReadLine();
                Console.WriteLine("Ingrese el valor por hora a pagarle a {0} ",nomEmpleado);
                float valorHora = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de horas trabajadas de {0} ",nomEmpleado);
                int cantHoras = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de años de antigüedad que tiene {0} ",nomEmpleado);
                int cantAñosAntiguedad = int.Parse(Console.ReadLine());

                importeHsTrabajadas = cantHoras * valorHora;
                importeAntiguedad = cantAñosAntiguedad * 150;
                importeTotal = (importeHsTrabajadas + importeAntiguedad) * descuento;


                Console.WriteLine("\n   -----------------------------------------------------------------\n");
                Console.WriteLine(" Nombre de empleado {0}",nomEmpleado);
                Console.WriteLine(" Horas trabajadas {0}, total a cobrar: ${1}",cantHoras,importeHsTrabajadas);
                Console.WriteLine(" Antigüedad {0}, total a cobrar: ${1}",cantAñosAntiguedad,importeAntiguedad);
                Console.WriteLine(" El total a cobrar, teniendo en cuenta el concepto de descuento es: ${0}\n\n",importeTotal);
            }
        }
    }
}
