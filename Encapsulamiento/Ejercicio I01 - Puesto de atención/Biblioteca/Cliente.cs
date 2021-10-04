using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        #region Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        #endregion



        #region Sobrecarga de operador
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool res;
            if (c1.numero == c2.numero)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        #endregion

    }
}

   