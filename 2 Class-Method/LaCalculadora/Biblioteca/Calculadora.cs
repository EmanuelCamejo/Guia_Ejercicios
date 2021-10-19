using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static double Calcular(double num1, char operacion, double num2)
        {
            double resultado= 0;
            bool val = Calculadora.Validar(num2);

            if (operacion=='*')
            {
                resultado = num1 * num2;                
            }
            if (operacion == '/' && val==true)
            {
                resultado = num1 / num2;
            }
            if (operacion == '+')
            {
                resultado = num1 + num2;
            }
            if (operacion == '-')
            {
                resultado = num1 - num2;               
            }
            return resultado;            
        }

        private static bool Validar(double num2)
        {
            bool respuesta;
            if (num2 == 0)
            {
                Console.WriteLine("Para realizar una cuenta de Dividir el número debe ser mayor que cero");
                respuesta = false;
            }
            else
            {
                respuesta = true;                
            }
            return respuesta;
        }
    }
}
