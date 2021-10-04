using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {

        #region Enumeradores
        public enum Puesto
        {
            Caja1, Caja2
        }
        #endregion

        private static int numeroActual;
        private Puesto puesto;

        #region Constructores
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        #endregion

        #region Propiedades
        public int NumeroActual(Puesto)
        {

        }


        public static int NumeroActual
        {
            get return numeroActual;
            set return numeroActual += 1;
            }

            #endregion

        }
    }
}
