using System;

namespace Biblioteca
{
    public class Boligrafo : IAcciones
    {
        ConsoleColor color;
        float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        { }

        public string ToString()
        {
            return "";
        }

        public ConsoleColor Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float UnidadesDeEscritura { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public EscrituraWrapper Escribir(string texto)
        {
            throw new NotImplementedException();
        }

        public bool Recargar(int unidad)
        {
            throw new NotImplementedException();
        }
    }
}
