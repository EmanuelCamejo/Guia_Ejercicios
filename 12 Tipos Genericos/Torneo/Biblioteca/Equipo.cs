using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        string nombre;
        DateTime fechaCreacion;


        public Equipo(string nombre, DateTime fecha)
        {
            
        }
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1==e2);
        }

        public string Ficha(Equipo e1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(e1.nombre + "Fundado el: " + e1.fechaCreacion);
            sb.AppendLine();
            return sb.ToString();
        }
    }

}
