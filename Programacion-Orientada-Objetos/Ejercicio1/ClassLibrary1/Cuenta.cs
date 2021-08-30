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

        public string GetMostrar()
        {
            return mostrar;
        }

        public int GetIngresar()
        {
            return ingresar;
        }
        public int GetRetirar()
        {
            return retirar;
        }


        public Cuenta(string mostrar, int ingresar, int retirar) 
        {
            this.mostrar = mostrar;
            this.ingresar = ingresar;
            this.retirar = retirar;
        }

        

    }
}
