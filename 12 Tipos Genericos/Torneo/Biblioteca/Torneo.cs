using System;
using System.Collections.Generic;

u

namespace Biblioteca
{
    public class Torneo<T>
    {
        List<T> equipos = new List<T>();
        string nombre;

        T atributo;
        public static bool operator ==(string nombre,List<T> equipos )
        {
            foreach (T item in equipos)
            {
                if (T.nombre == nombre)
                    return true;

            }
            return false;
        }

        public static bool operator !=(T, T)
        {            
            return !(e1==e2);
        }

    }
}
