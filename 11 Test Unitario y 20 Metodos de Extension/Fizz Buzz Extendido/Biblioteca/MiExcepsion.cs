using System;

namespace Biblioteca
{
    public static class MiExcepsion
    {
        public static string FizzBuzz(this Int32 num)
        {
            string resultado="";
           
                if (num % 3 == 0)
                {
                    resultado="Fizz";
                }
                if (num % 5 == 0)
                {
                    resultado += "Buzz";
                }
                if (string.IsNullOrEmpty(resultado))
                {
                    resultado += num.ToString();
                }
            return resultado;
        }
    }
}
