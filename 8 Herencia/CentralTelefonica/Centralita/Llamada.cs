using System;

namespace Centralita
{
    public class Llamada
    {
        enum EtipoLlamada
        {
            Local,Provincial,Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        public float Duracion
        {
            get { return duracion; }
        }
        public string NroDestino 
        {
            get { return nroDestino; } 
         }
        public string NroOrigen 
        {
            get { return nroOrigen; } 
        }

        #endregion

        #region Constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Metodos
        public virtual string Mostrar()
        {
            return "";
        }

        public int OrdenarPorDuración(Llamada llamada1, Llamada llamada2)
        {
            return 1;                        
        }

        #endregion



    }
}
