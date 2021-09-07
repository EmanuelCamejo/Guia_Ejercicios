using System;

namespace Billete
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static  GetCotizacion(double cotizRespectoDolar)
        {
            this.cotizRespectoDolar = cotizRespectoDolar;
            
        }

    }
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        public static double GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }
    }
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;
    }
}
