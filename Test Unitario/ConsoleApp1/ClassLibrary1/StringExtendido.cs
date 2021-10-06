using System;

namespace ClassLibrary1
{
    public static class Int32Extendido
    {
        public static string FizzBuzz(this Int32 num)
        {
            if (num % 3 == 0 && num % 5==0)
            {
                return "FizzBuzz";
            }
            if (num % 3 == 0 && num % 5 != 0)
            {
                return "Fizz";
            }
            else 
            {
                return "Buzz";
            }
        }
        
    }
}
