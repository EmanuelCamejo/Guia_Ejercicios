using System;
using Biblioteca;


namespace Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Beep(300, 200);
            //Console.WriteLine(DateTime.Now.AddMinutes(30));

            int año, mes, dia;
            DateTime fechaActual;
            DateTime fechaNacim;

            Console.WriteLine("Ingreso de la fecha de nacimiento\n");
            Console.Write("Ingrese año: ");
            año = FechaValida.ValidarAño();
            Console.Write("Ingrese Mes: ");
            mes = FechaValida.ValidarMes();
            Console.Write("Ingrese Dia: ");
            dia = FechaValida.ValidarDia(mes, año);

            //fechaNacim = new DateTime(año, mes, dia);
            //fechaActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //DateTime star = new DateTime(1985,07,06); 
            //Console.WriteLine(star);
            //DateTime stop = DateTime.Now.AddMinutes(30);
            //Console.WriteLine(stop);
            //int minutos = stop.Minute - star.Minute;
            //Console.WriteLine(minutos);

            //TimeSpan res = stop.Subtract(star);
            //int res2 = res.Days / 365;
            //Console.WriteLine(res.Days);
            //Console.WriteLine(res2);




        }
    }
}
