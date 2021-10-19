using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool res;

            if (respuesta == "S" || respuesta == "s")
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
