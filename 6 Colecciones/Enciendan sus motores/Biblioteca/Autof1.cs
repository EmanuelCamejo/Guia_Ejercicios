using System;
using System.Text;

namespace Biblioteca
{
    public class Autof1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Constructor
        public Autof1(short numero, string escuderia)
        {
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region Metodo Getters y Setters

        public short GetCantidadCombustible()
        {
            return cantidadCombustible;
        }
        public void SetCantidadCombustible(short nuevaCantidadCombustible)
        {
            cantidadCombustible = nuevaCantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public void SetEnCompetencia(bool nuevaEnCompetencia)
        {
            enCompetencia = nuevaEnCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        public void SetVueltasRestantes(short nuevaVueltasRestantes)
        {
            this.vueltasRestantes = nuevaVueltasRestantes;
        }

        #endregion


        #region Sobrecarga de Operadores
        public static bool operator ==(Autof1 a1, Autof1 a2)
        {

            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }
        public static bool operator !=(Autof1 a1, Autof1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto "+ numero);
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Cantidad de Vueltas Restantes: "+ this.vueltasRestantes);
            return sb.ToString();
        }

        #endregion


    }

}
