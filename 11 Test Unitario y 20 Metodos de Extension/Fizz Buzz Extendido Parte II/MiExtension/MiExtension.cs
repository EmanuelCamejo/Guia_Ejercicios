using System;

namespace Biblioteca
{
    public static class MiExtension
    {
        public static string FizzBuss(this Int32 num)
        {
            string resultado = "";
            if (num % 3 == 0)
            {
                resultado += "Fizz";
            }
            if (num % 5 == 0)
            {
                resultado += "Buzz";
            }
            if(string.IsNullOrEmpty(resultado))
            {
                resultado = num.ToString();
            }

            return resultado;
        }

    }
}
