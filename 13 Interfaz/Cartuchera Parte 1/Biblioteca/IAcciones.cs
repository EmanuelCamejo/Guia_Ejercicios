using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    interface IAcciones
    {
        ConsoleColor Color
        { get; set; }
        float UnidadesDeEscritura
        { get; set; }

        EscrituraWrapper Escribir(string texto);
        bool Recargar(int unidad);
    }
}
