using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region Constructores
        static Euro()
        {
            Euro.cotzRespectoDolar = 1/1.17F;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;            
        }

        #endregion

        #region Metodos de Acceso

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizador()
        {
            return Euro.cotzRespectoDolar;
        }

        #endregion

        #region Sobrecarga de operadores

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizador());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Euro)e);
        }



        #endregion





    }
}
