using System;

namespace Biblioteca
{
    public class Conversor
    {
        private double numero;

        #region Propiedades

        public string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }

        #endregion

        #region Constructores
        public Conversor() : this(0)
        {

        }

        public Conversor(double num1)
        {
            this.numero = num1;
        }

        public Conversor(string strNum1)
        {
            this.numero = double.Parse(strNum1);
        }
        #endregion

        #region Metodos
        private double ValidarOperando(string strNumero)
        {
            double resultado, num;
            bool esNumerico = double.TryParse(strNumero, out num);

            if (esNumerico)
            {
                resultado = num;
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        private bool EsBinario(string binario)
        {
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public string DecimalABinario(double numero)
        {
            string valorBinario = string.Empty;
            int resultadoDivicion = (int)numero;
            int resto;
            if (resultadoDivicion >= 0)
            {
                do
                {
                    resto = resultadoDivicion % 2;
                    resultadoDivicion /= 2;
                    valorBinario = resto.ToString() + valorBinario;

                } while (resultadoDivicion > 0);
            }
            return valorBinario;
        }

        public string DecimalABinario(string numero)
        {
            string valorBinario = DecimalABinario(double.Parse(numero));
            return valorBinario;
        }

        public double BinarioADecimal(string binario)
        {
            double resultado = 0;
            if (EsBinario(binario))
            {
                int cantidadCaracteres = binario.Length;
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            return resultado;
        }

        #endregion

        #region otros

        //private bool EsBinario(string binario)
        //{
        //    foreach (char c in binario)
        //    {
        //        if (c != '0' && c != '1')
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //public static string ConvertirDecimalABinario(int binario)
        //{
        //    double resultado = 0;
        //    if (EsBinario(binario))
        //    {
        //        int cantidadCaracteres = binario.Length;
        //        foreach (char caracter in binario)
        //        {
        //            cantidadCaracteres--;
        //            if (caracter == '1')
        //            {
        //                resultado += (int)Math.Pow(2, cantidadCaracteres);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Valor inválido");
        //    }
        //    return resultado;

        //string binario="";

        //while (numeroEntero / 2 > 0)
        //{
        //    if (numeroEntero % 2 == 0)
        //        binario = "0" + binario;
        //    if (numeroEntero % 2 == 1)
        //        binario = "1" + binario;
        //    numeroEntero = numeroEntero / 2;
        //}
        //if (numeroEntero == 0)
        //{
        //    binario = "0" + binario;
        //}
        //if (numeroEntero == 1)
        //{
        //    binario = "1" + binario;
        //}

        //    return binario;

        //}
        //public static int ConvertirBinarioADecimal(int numeroEntero)
        //{
        //    int dec=0;
        //    return dec;
        //}
        #endregion

    }
}
