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

        #region  Metodo
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        #endregion

        #region Operadores de Conversión

        public static explicit operator int(Sumador s1)
        {
            return s1.cantidadSumas;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
