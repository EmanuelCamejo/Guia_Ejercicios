using System;

namespace Biblioteca
{
    public class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region Constructores
        static Pesos()
        {
            Pesos.cotzRespectoDolar = 1/102.65f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotzRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos de Acceso
        public  double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotzRespectoDolar;
        }

        #endregion

        #region Sobrecarga de operadores

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static explicit operator Pesos(Dolar p)
        {
            return new Pesos((p.cantidad * Pesos.GetCotizacion));
        }

        #endregion 


    }
}
