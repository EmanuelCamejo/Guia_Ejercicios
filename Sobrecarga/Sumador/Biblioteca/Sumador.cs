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
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;            
            return a+b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        #endregion

        public static explicit operator Sumador(long cantidaSumas)
        {
            return cantidaSumas;
        }
    }
}
