using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        # region Constructores
        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #endregion

        #region Metodos de acceso

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizazcion()
        {
            return Dolar.cotzRespectoDolar;
        }


        #endregion

        #region Sobrecarga de operadores

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos((d.cantidad * Pesos.GetCotizacion()));
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.cantidad * Euro.GetCotizador()));
        }

        #endregion



    }
}
