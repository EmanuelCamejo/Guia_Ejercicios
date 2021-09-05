using System;

namespace Biblioteca
{
    public class Conversor
    {

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario="";
            
            while (numeroEntero / 2 > 0)
            {
                if (numeroEntero % 2 == 0)
                    binario = "0" + binario;
                if (numeroEntero % 2 == 1)
                    binario = "1" + binario;
                numeroEntero = numeroEntero / 2;
            }
            if (numeroEntero == 0)
            {
                binario = "0" + binario;
            }
            if (numeroEntero == 1)
            {
                binario = "1" + binario;
            }

                return binario;
        }
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int dec=0;
            return dec;
        }
    }
}
