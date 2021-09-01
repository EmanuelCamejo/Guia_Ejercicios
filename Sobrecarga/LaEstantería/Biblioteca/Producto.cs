using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public string GetCodigoDeBarra()
        {
            return codigoDeBarra;
        }
        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }

        
        public static explicit operator string (Producto p)
        {
            return p1.codigoDeBarra;
        }

        public static bool operator ==(Producto p1,Producto p2)
        {
            return p1.marca==p2.marca && p1.codigoDeBarra==p2.codigoDeBarra;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            return p1.marca == marca;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }

        





    }
}
