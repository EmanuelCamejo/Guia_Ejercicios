using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
             bool retorno;
            
                if (valor <= max && valor >= min)
                {
                    retorno = true;
                }
                else 
                {
                    retorno= false;
                }
            return retorno;
            //return  if (valor <= max && valor >= min);
        }

    }
}
