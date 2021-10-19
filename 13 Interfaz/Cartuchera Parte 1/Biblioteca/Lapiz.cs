using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Lapiz : IAcciones
    {
        float tamanioMina;

        public Lapiz(int unidades)
        { }


        public string Tostring() { return ""; }

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
