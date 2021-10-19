using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<Autof1> competidores;


        private Competencia()
        {
            competidores = new List<Autof1>();              
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        #region Sobrecarga operadores
        public static bool operator +(Competencia c, Autof1 a)
        {

            if (c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                Random rdn = new Random();
                a.SetCantidadCombustible((short)rdn.Next(15, 100));
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, Autof1 a)
        {

            if (c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, Autof1 a)
        {
            foreach (Autof1 item in c.competidores)
            {
                if (item == a)
                    return true;
            }

            return false;    
        }

        public static bool operator !=(Competencia c, Autof1 a)
        {

            return !(c==a);
        }

        #endregion

        #region Metodo
        public string MostraDatos()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------COMPETENCIA------");
            sb.AppendLine("COMPETIDORES: " + this.cantidadCompetidores);

            foreach (Autof1 item in this.competidores)
            {
                sb.AppendLine("----------------------");
                sb.AppendLine(item.MostrarDatos());
                sb.AppendLine("----------------------");
            }
            return sb.ToString();
        }

        #endregion





    }


}
