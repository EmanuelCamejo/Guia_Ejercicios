using System;
using Biblioteca;

namespace Torneo
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("TBasquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("TFuchibol");

            EquipoBasquet e1 = new EquipoBasquet("Bulls", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("Lakers", DateTime.Now);
            EquipoBasquet e3 = new EquipoBasquet("Boston", DateTime.Now);

            _ = torneoBasquet + e1;
            _ = torneoBasquet + e2;
            _ = torneoBasquet + e3;

            EquipoFutbol ef1 = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol ef2 = new EquipoFutbol("Bosta", DateTime.Now);
            EquipoFutbol ef3 = new EquipoFutbol("Independiente", DateTime.Now);
            EquipoFutbol ef4 = new EquipoFutbol("Racing", DateTime.Now);

            _ = torneoFutbol + ef1;
            _ = torneoFutbol + ef2;
            _ = torneoFutbol + ef3;
            _ = torneoFutbol + ef4;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.WriteLine();
            
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.ReadKey();

        }
    }
}
