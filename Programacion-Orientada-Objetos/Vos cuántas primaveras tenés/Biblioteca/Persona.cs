using System;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        #region Constructor
        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }
        #endregion

        #region Metodos de Accesos
        public string GetNombre()
        {
            return this.nombre;

        }
        public void SetNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        public int GetDni()
        {
            return this.dni;

        }
        public void SetDni(int nuevoDni)
        {
            this.dni = nuevoDni;
        }

        public string GetfechaNacimiento()
        {
            return this.fechaNacimiento.ToShortDateString();
        }
        public void SetfechaNacimiento(DateTime nuevafechaNacimiento)
        {
            this.fechaNacimiento = nuevafechaNacimiento;
        }
        #endregion

        #region Metodo
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int dias=hoy.Now.Day;
            TimeSpan edad = fechaNacimiento - hoy;
            return edad.Days;
        }
        #endregion

    }
}
