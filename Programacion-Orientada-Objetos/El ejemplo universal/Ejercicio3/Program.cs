using System;
using Biblioteca;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Emanuel","Camejo","00001");
            Estudiante e2 = new Estudiante("Ulises", "Camejo", "00002");
            Estudiante e3 = new Estudiante("Yamila", "Valenzisi", "00003");
            e1.SetNotaPrimerParcial(3);
            e1.SetNotaSegundoParcial(6);

            e2.SetNotaPrimerParcial(7);
            e2.SetNotaSegundoParcial(7);

            e3.SetNotaPrimerParcial(10);
            e3.SetNotaSegundoParcial(9);


            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());


        }
    }
}
