using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        #region Metodos
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }
        public double GetCantidad()
        {
            return cantidad;
        }



        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Razon Social: {titular}\nMonto actual: {cantidad} ");
            return stringBuilder.ToString();
        }

        public void Ingresar(double num)
        {
            if (num > 0)
            {
                this.cantidad+=num;
            }
        }

        public void Retirar(double num)
        {           
                this.cantidad -= num;
        }

        #endregion


    }
}
