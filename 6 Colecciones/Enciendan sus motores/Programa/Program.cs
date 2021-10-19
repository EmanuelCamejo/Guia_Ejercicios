using System;
using Biblioteca;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Autof1 a1 = new Autof1(5, "Tomala voz damela a mi");
            Autof1 a2 = new Autof1(8, "Toco y voy");
            Autof1 a3 = new Autof1(10, "La mano de Dios ");
            Autof1 a4 = new Autof1(1, "Mira que te como");
            Competencia c1 = new Competencia(10, 3);

            if (c1 + a1)
            {
                Console.WriteLine("Formulario cargado de: ");
                Console.WriteLine(a1.MostrarDatos());
            }
            
                       
        }
    }
}
