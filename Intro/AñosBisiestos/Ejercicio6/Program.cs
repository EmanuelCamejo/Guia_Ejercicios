using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int bisiesto=0;
            Console.WriteLine("Ingresar rango de años para saber los bisiestos");
            
            Console.WriteLine("Ingresar año Inicio");
            int anoIin = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar año Fin");
            int anoFin = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = anoIin; i <= anoFin; i++)
            {
                if (i % 4 == 0)
                {

                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            bisiesto = i;
                            Console.WriteLine(@"{0} es bisiesto", bisiesto);
                        }
                        else
                        {
                            //Console.WriteLine("{0} no es bisiesto", i);
                        }
                    }
                    else
                    {
                        bisiesto = i;
                        Console.WriteLine(@"{0} es bisiesto", bisiesto);
                    }
                }
                else 
                {
                    //Console.WriteLine("{0} no es bisiesto", i);
                }
                
            }

        }
    }
}
