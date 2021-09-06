using System;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double resultado = Math.Pow(2, longitudLado);
            return resultado;
        }

        public static double CalcularAreaTriangulo(double basse, double altura)
        {
            double resultado = (basse * altura) / 2;
            return resultado;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double resultado = Math.PI*Math.Pow(2,radio);
            return resultado;
        }
    }
}
