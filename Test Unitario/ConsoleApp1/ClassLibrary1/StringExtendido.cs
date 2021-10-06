using System;

namespace ClassLibrary1
{
    public static class Int32Extendido
    {
        public static string FizzBuzz(this Int32 num)
        {
            string resultado = " ";
            if (num % 3 == 0 && num % 5==0)
            {
                resultado="FizzBuzz";
            }
            if (num % 3 == 0 && num % 5 != 0)
            {
                resultado="Fizz";
            }
            if (num % 3 != 0 && num % 5 == 0)
            {
                resultado= "Buzz";
            }
            if (num % 3 != 0 && num % 5 != 0)
            {
                resultado = "NoFizzBuzz";
            }
                return resultado;
        }
        
    }
}
