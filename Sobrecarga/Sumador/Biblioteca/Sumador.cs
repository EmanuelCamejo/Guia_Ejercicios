using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;
        private long num1, num2, resultado;

        #region Contructores
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        #endregion

        #region Metodos
        public long Sumar(long num1, long num2)
        {
            cantidadSumas++;
            long resultado = num1 + num2;
            return resultado;
        }
        public string Sumar(string a, string b)
        {
            return a + b;
        }
        #endregion

        public static explicit operator Sumador(long cantidaSumas)
        {

            return cantidaSumas;
        }
    }
}
