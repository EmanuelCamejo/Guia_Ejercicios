using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        #region Constructores
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador(): this(0)
        {
            
        }
        #endregion

        #region Metodos
        public long Sumar(long a, long b)
        {
            this.cantidadSumas += 1;
            return a+b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas += 1;
            string res = a + b;
            return res;
        }
        #endregion

        #region Sobrecarga de operadores
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool flag;
            if (s1.cantidadSumas==s2.cantidadSumas)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        #endregion




    }
}
