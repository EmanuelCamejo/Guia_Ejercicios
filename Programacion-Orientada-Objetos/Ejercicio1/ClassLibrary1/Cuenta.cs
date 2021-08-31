using System;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
        private string mostrar;
        private int ingresar;
        private int retirar;
        

        public Cuenta(string mostrar, int ingresar, int retirar) 
        {
            this.mostrar = mostrar;
            this.ingresar = ingresar;
            this.retirar = retirar;
        }
        public string GetTitular()
        {
            return 
        }

        public string GetTitular()
        {

        }
        public string GetCantidad()
        {

        }

        public string Mostrar()
        {
           return $"{GetTitular()}, Cantidad: {GetCantidad()}" ;
        }
        public void Ingresar(double monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }
        public int GetRetirar()
        {
            return retirar;
        }
    }
}
